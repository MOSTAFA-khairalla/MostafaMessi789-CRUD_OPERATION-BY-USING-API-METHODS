using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication31.Migrations
{
    public partial class Ao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    branchID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    governate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    regionCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buildingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    postalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    room = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    landmark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    additionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    approach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    packaging = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateValidity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exportPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    countryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    grossWeight = table.Column<double>(type: "float", nullable: false),
                    netWeight = table.Column<double>(type: "float", nullable: false),
                    terms = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rate = table.Column<double>(type: "float", nullable: false),
                    amount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bankAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bankAccountNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bankAccountIBAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    swiftCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    terms = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Roots",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roots", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UnitValues",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    currencySold = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    amountEGP = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitValues", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Issuers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    addressId = table.Column<int>(type: "int", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issuers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Issuers_Addresses_addressId",
                        column: x => x.addressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Receivers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    addressId = table.Column<int>(type: "int", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receivers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Receivers_Addresses_addressId",
                        column: x => x.addressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    issuerid = table.Column<int>(type: "int", nullable: true),
                    receiverid = table.Column<int>(type: "int", nullable: true),
                    documentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    documentTypeVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateTimeIssued = table.Column<DateTime>(type: "datetime2", nullable: false),
                    taxpayerActivityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    internalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    purchaseOrderReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    purchaseOrderDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salesOrderReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salesOrderDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    proformaInvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paymentid = table.Column<int>(type: "int", nullable: true),
                    deliveryId = table.Column<int>(type: "int", nullable: true),
                    totalDiscountAmount = table.Column<double>(type: "float", nullable: false),
                    totalSalesAmount = table.Column<double>(type: "float", nullable: false),
                    netAmount = table.Column<double>(type: "float", nullable: false),
                    totalAmount = table.Column<double>(type: "float", nullable: false),
                    extraDiscountAmount = table.Column<double>(type: "float", nullable: false),
                    totalItemsDiscountAmount = table.Column<double>(type: "float", nullable: false),
                    Rootid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_Deliveries_deliveryId",
                        column: x => x.deliveryId,
                        principalTable: "Deliveries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documents_Issuers_issuerid",
                        column: x => x.issuerid,
                        principalTable: "Issuers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documents_Payments_paymentid",
                        column: x => x.paymentid,
                        principalTable: "Payments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documents_Receivers_receiverid",
                        column: x => x.receiverid,
                        principalTable: "Receivers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Documents_Roots_Rootid",
                        column: x => x.Rootid,
                        principalTable: "Roots",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    itemType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    itemCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unitType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantity = table.Column<double>(type: "float", nullable: false),
                    internalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salesTotal = table.Column<double>(type: "float", nullable: false),
                    total = table.Column<double>(type: "float", nullable: false),
                    valueDifference = table.Column<double>(type: "float", nullable: false),
                    totalTaxableFees = table.Column<double>(type: "float", nullable: false),
                    netTotal = table.Column<double>(type: "float", nullable: false),
                    itemsDiscount = table.Column<double>(type: "float", nullable: false),
                    unitValueid = table.Column<int>(type: "int", nullable: true),
                    discountId = table.Column<int>(type: "int", nullable: true),
                    DocumentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceLines_Discount_discountId",
                        column: x => x.discountId,
                        principalTable: "Discount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceLines_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceLines_UnitValues_unitValueid",
                        column: x => x.unitValueid,
                        principalTable: "UnitValues",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Signatures",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    signatureType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signatures", x => x.id);
                    table.ForeignKey(
                        name: "FK_Signatures_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaxTotals",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    taxType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    amount = table.Column<double>(type: "float", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxTotals", x => x.id);
                    table.ForeignKey(
                        name: "FK_TaxTotals_Documents_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaxableItem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    taxType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    amount = table.Column<double>(type: "float", nullable: false),
                    subType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rate = table.Column<double>(type: "float", nullable: false),
                    InvoiceLineId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxableItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_TaxableItem_InvoiceLines_InvoiceLineId",
                        column: x => x.InvoiceLineId,
                        principalTable: "InvoiceLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_deliveryId",
                table: "Documents",
                column: "deliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_issuerid",
                table: "Documents",
                column: "issuerid");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_paymentid",
                table: "Documents",
                column: "paymentid");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_receiverid",
                table: "Documents",
                column: "receiverid");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_Rootid",
                table: "Documents",
                column: "Rootid");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceLines_discountId",
                table: "InvoiceLines",
                column: "discountId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceLines_DocumentId",
                table: "InvoiceLines",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceLines_unitValueid",
                table: "InvoiceLines",
                column: "unitValueid");

            migrationBuilder.CreateIndex(
                name: "IX_Issuers_addressId",
                table: "Issuers",
                column: "addressId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivers_addressId",
                table: "Receivers",
                column: "addressId");

            migrationBuilder.CreateIndex(
                name: "IX_Signatures_DocumentId",
                table: "Signatures",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxableItem_InvoiceLineId",
                table: "TaxableItem",
                column: "InvoiceLineId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxTotals_DocumentId",
                table: "TaxTotals",
                column: "DocumentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Signatures");

            migrationBuilder.DropTable(
                name: "TaxableItem");

            migrationBuilder.DropTable(
                name: "TaxTotals");

            migrationBuilder.DropTable(
                name: "InvoiceLines");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "UnitValues");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "Issuers");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Receivers");

            migrationBuilder.DropTable(
                name: "Roots");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
