using BaseDataValidatorLibrary.LanguageExtensions;
using DirectoryHelpersLibrary.Classes;
using ValidatingFormProject.Classes;
using ValidatingFormProject.Extensions;
using WindowsFormsLibrary.Classes;
using WindowsFormsLibrary.LanguageExtensions;
using static BaseDataValidatorLibrary.Helpers.ValidationHelper;
using Customer = ValidatingFormProject.Models.Customer;

namespace ValidatingFormProject
{
    public partial class MainForm : Form
    {

        private readonly BindingSource _customerBindingSource = new();
        private readonly Dictionary<string, Control> _controls = new();
        public MainForm()
        {
            InitializeComponent();
            
            Shown += MainForm_Shown;

            SolutionNameLabel.Text = Folders.CurrentSolutionName().SplitCamelCase();
            

            IEnumerable<Control> items = this.Descendants<Control>()
                .Where(x => x.Tag is not null);

            foreach (Control item in items)
            {
                _controls.Add(item.Tag!.ToString()!, item);
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            CountryComboBox.DataSource = Operations.Countries();

            // so we start-off with a valid Customer
            CountryComboBox.SelectedIndex = 1;

            SocialSecurityNumberTextBox.ToggleShow(false);

            // This sets up for binding to the sole customer
            _customerBindingSource.DataSource = Operations.Customers;

            // data bind to customer properties
            FirstNameTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.FirstName));
            LastNameTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.LastName));
            BirthDatePicker.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.BirthDate), true, DataSourceUpdateMode.OnPropertyChanged);
            PinTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.Pin));
            SocialSecurityNumberTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.SocialSecurity));
            PostalCodeTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.PostalCode));
            CountryComboBox.DataBindings.Add(new Binding("SelectedValue", _customerBindingSource, nameof(Customer.Country), true, DataSourceUpdateMode.OnPropertyChanged));
            CreditCardTextBox.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.CreditCardNumber));
            AppointmentDateTimePicker1.DataBindings.Add("Text", _customerBindingSource, nameof(Customer.AppointmentDate));

            NotesComboBox.SelectedIndex = 3;
            _customerBindingSource.Customer().NotesList = Operations.CreateNotes();

        }

        private void ShowHidePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SocialSecurityNumberTextBox.ToggleShow(ShowHidePasswordCheckBox.Checked);
        }

        /// <summary>
        /// Validate Customer, if a property fails validation display issue
        /// with error provider
        /// </summary>
        private void ValidateButton_Click(object sender, EventArgs e)
        {
            if (_customerBindingSource.Current is null)
            {
                Dialogs.Information(this, "Customer is in an invalid state");
            }
            else
            {
                // clear error provider text on each control
                foreach (var control in _controls)
                {
                    errorProvider1.SetError(control.Value,"");
                }
                var customer = _customerBindingSource.Customer();

                customer.NotesList = Operations.CreateNotes(Convert.ToInt32(NotesComboBox.Text));

                var (success, container) = IsValidEntity(customer);

                if (!success)
                {
                    FunStuff.Shake(this);
                    // set error message for properties not valid
                    foreach (var item in container)
                    {
                        if (_controls.TryGetValue(item.Name, out var control))
                        {
                            errorProvider1.SetError(control, item.Description);
                        }
                    }
                }
                else
                {
                    Dialogs.Information(this,"Valid");
                }
            }

        }

        /// <summary>
        /// Cheap way to reset values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            try
            {
                f.ShowDialog();
            }
            finally
            {
                f.Dispose();
            }
        }
    }
}
