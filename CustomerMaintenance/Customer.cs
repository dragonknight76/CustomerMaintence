using System;

namespace CustomerMaintenance
{
    public class Customer
	{
		private string firstName;
		private string lastName;
		private string email;

        public Customer()
		{
		}
        /// <summary>
        /// Populate Customer strings via overloaded method
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        public Customer(string firstName, string lastName, string email)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.email = email;
		}
        /// <summary>
        /// Get First Name
        /// </summary>
        public string FirstName
		{
            
			get
			{
				return firstName;
			}
			set
			{
                firstName = value;
			}
		}
        /// <summary>
        /// Get Last Name
        /// </summary>
        public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				lastName = value;
			}
		}
        /// <summary>
        /// Get E-mail
        /// </summary>
        public string Email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
			}
		}
        /// <summary>
        /// Generate display
        /// </summary>
        /// <returns>Returns concant information</returns>
        public string GetDisplayText()
		{
			return firstName + " " + lastName + ", " + email;
		}
	}
}