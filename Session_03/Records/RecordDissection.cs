using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03.Records
{
    public class RecordDissection
    {
        public RecordDissection()
        {

        }
    }

    public class Person : IEquatable<Person>
    {
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public void Deconstruct(
          out string firstName, out string lastName)
        {
            firstName = this.FirstName;
            lastName = this.LastName;
        }

        public string FirstName { get; init; }
        public string LastName { get; init; }

        public bool Equals(Person? other) =>
          other?.FirstName.Equals(this.FirstName) == true &&
          other?.LastName.Equals(this.LastName) == true;

        public override bool Equals(object? other) =>
          this.Equals(other as Person);

        public override int GetHashCode() =>
          HashCode.Combine(this.FirstName, this.LastName);

        public override string ToString() =>
          $"{nameof(Person)} {{ " +
          $"{nameof(FirstName)} = {FirstName}, " +
          $"{nameof(LastName)} = {LastName} }}";
    }
}
