using System;
using Microsoft.EntityFrameworkCore;

namespace Contacts.Models
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
