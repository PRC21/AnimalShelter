using System;
using System.IO;
using System.Windows.Forms;

namespace AnimalShelter
{
    [Serializable]
    public partial class AdministrationForm : Form
    {
        private readonly string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" +
            "AnimalShelter.bin";

        private readonly string exportFile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" +
                                    "exportedAnimalShelter.txt";
        public Administration Administration { get; private set; }

        enum Refreshes : int { Add = 0, Find = 1, Reserve = 2 };

        private void IsReserved(bool isReserved)
        {
            Animal animal = Administration.FindAnimal((int)nudChipRegistrationNumber.Value);
            if (animal != null)
            {
                if (isReserved == true)
                {
                    animal.IsReserved = true;
                }
                else
                {
                    animal.IsReserved = false;
                }
            }
        }
        public AdministrationForm()
        {
            InitializeComponent();
            Administration = new Administration();
            Administration.Animals.Add(new Dog(1, new SimpleDate(21, 5, 1999), "Bello", new SimpleDate(18, 02, 2016)));
            Administration.Animals.Add(new Cat(2, new SimpleDate(3, 9, 2010), "Felix", "Grumpy"));
            Administration.Animals.Add(new Cat(3, new SimpleDate(17, 12, 1995), "Poekie", ""));
            Administration.Animals.Add(new Dog(5, new SimpleDate(6, 7, 2005), "Blaffie", new SimpleDate(29, 9, 2015)));
            RefreshFormInputFields(2);
            Administration.Export(exportFile);
        }
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            bool addingSuccesfull = false;
            int chipRegistrationNumber;
            bool correctChipRegistrationNumber = Int32.TryParse(tbChipRegistrationNumber.Text, out chipRegistrationNumber);

            if (correctChipRegistrationNumber)
            {
                
                if (rbCat.Checked)
                {
                    Animal cat = new Cat(chipRegistrationNumber, new SimpleDate(dtpDateOfBirth.Value.Day, dtpDateOfBirth.Value.Month, dtpDateOfBirth.Value.Year), tbName.Text, tbBadHabits.Text);
                    addingSuccesfull = Administration.Add(cat);
                    if (addingSuccesfull)
                    {
                        lbUnreserved.Items.Add(cat);
                    }
                    //RefreshFormInputFields(Refreshes.Add);
                    RefreshFormInputFields(0);
                } 
                else if (rbDog.Checked)
                {
                    Animal dog = new Dog(chipRegistrationNumber, new SimpleDate(dtpDateOfBirth.Value.Day, dtpDateOfBirth.Value.Month, dtpDateOfBirth.Value.Year), tbName.Text, new SimpleDate(dtpLastWalkDate.Value.Day, dtpLastWalkDate.Value.Month, dtpLastWalkDate.Value.Year));
                    addingSuccesfull = Administration.Add(dog);
                    if (addingSuccesfull)
                    {
                        lbUnreserved.Items.Add(dog);
                    }
                    RefreshFormInputFields(0);
                }
                else
                {
                    MessageBox.Show("Er is geen Kat of Hond geselecteerd");
                }
            }
            else
            {
                MessageBox.Show("U heeft niet alleen getallen ingevoerd");
            }
        }

        // Onderstaande methode aanpassen, zodat de Administration.FindAnimal kan worden gebruikt
        private void btnReserve_Click(object sender, EventArgs e)
        {
            IsReserved(true);
            RefreshFormInputFields(1);
        }

        // Onderstaande methode aanpassen, zodat de Administration.FindAnimal kan worden gebruikt
        private void btnUnReserve_Click(object sender, EventArgs e)
        {
            IsReserved(false);
            RefreshFormInputFields(1);
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int result;

            if (Int32.TryParse(nudChipRegistrationNumber.Text, out result))
            {
                Administration.RemoveAnimal(result);
                RefreshFormInputFields(1);
            }
            else
            {
                MessageBox.Show("U heeft geen geldig chip registratie nummer ingevoerd");
            }
        }

        private void btnFindAnimal_Click(object sender, EventArgs e)
        {
            int result;
            if (Int32.TryParse(tbFindAnimal.Text, out result))
            {
                lblFindAnimalResult.Text = Administration.FindAnimal(result).ToString();
                RefreshFormInputFields(2);
            }
            else
            {
                MessageBox.Show("U heeft geen geldig chip registratie nummer ingevoerd");
            }
        }

        private void RefreshFormInputFields(int refreshLocatie)
        {
            if (refreshLocatie == 0)
            {
                rbCat.Checked = false;
                rbDog.Checked = false;
                tbChipRegistrationNumber.ResetText();
                dtpDateOfBirth.ResetText();
                tbName.ResetText();
                dtpLastWalkDate.ResetText();
                tbBadHabits.ResetText();
            }
            else if (refreshLocatie == 1)
            {
                lbReserved.Items.Clear();
                lbUnreserved.Items.Clear();
                foreach (Animal existingAnimal in Administration.Animals)
                {
                    if (existingAnimal.IsReserved)
                    {
                        lbReserved.Items.Add(existingAnimal);
                    }
                    else if (existingAnimal.IsReserved == false)
                    {
                        lbUnreserved.Items.Add(existingAnimal);
                    }
                }
            }
            else if (refreshLocatie == 2)
            {
                tbFindAnimal.ResetText();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Administration.Save(fileName);
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                Administration.Load(fileName);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //update
            }
        }
    }
}
