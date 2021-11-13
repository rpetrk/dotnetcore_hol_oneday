﻿namespace AutoLot.Models.Entities;

[Table("Customers", Schema = "dbo")]
[EntityTypeConfiguration(typeof(CustomerConfiguration))]
public class Customer : BaseEntity
{
    public Person PersonInformation { get; set; } = new Person();
    [InverseProperty(nameof(CreditRisk.CustomerNavigation))]
    public IEnumerable<CreditRisk> CreditRisks { get; set; } = new List<CreditRisk>();
    [InverseProperty(nameof(Order.CustomerNavigation))]
    public IEnumerable<Order> Orders { get; set; } = new List<Order>();

}
