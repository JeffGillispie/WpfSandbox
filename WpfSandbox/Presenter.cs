namespace WpfSandbox
{
    using System.Collections.Generic;

    public class Presenter : ObservableObject
    {
        private List<Person> people = (new DataModel()).People;

        public List<Person> People
        {
            get
            {
                return this.people;
            }

            set
            {
                if (this.people != value)
                {
                    this.people = value;
                    OnPropertyChanged(nameof(People));
                }
            }
        }
    }
}
