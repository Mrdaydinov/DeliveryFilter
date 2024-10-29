using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliveryFilter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    District = table.Column<string>(type: "TEXT", nullable: false),
                    Weight = table.Column<double>(type: "REAL", nullable: false),
                    DeliveryTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("1cb0139e-60e5-4cb7-adf7-8e56803a03cd"), new DateTime(2024, 10, 29, 19, 19, 49, 882, DateTimeKind.Local).AddTicks(5233), "Торговый", 1.6000000000000001 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("2e233196-a8ff-49d3-b486-6b44a638e10d"), new DateTime(2024, 10, 29, 19, 9, 49, 882, DateTimeKind.Local).AddTicks(5223), "Научный", 2.2000000000000002 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("3d6d6501-c782-4638-99ef-8f428c6c85b8"), new DateTime(2024, 10, 29, 19, 39, 49, 882, DateTimeKind.Local).AddTicks(5205), "Северный", 2.0 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("5cb76fea-875e-4289-8b99-2d796fad4e6b"), new DateTime(2024, 10, 29, 22, 49, 49, 882, DateTimeKind.Local).AddTicks(5220), "Промышленный", 3.5 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("629a5460-5628-43af-9838-62c520de58f6"), new DateTime(2024, 10, 29, 20, 9, 49, 882, DateTimeKind.Local).AddTicks(5212), "Советский", 2.2999999999999998 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("62a4e96b-e759-48f8-bd14-3e4485d2afd3"), new DateTime(2024, 10, 29, 20, 44, 49, 882, DateTimeKind.Local).AddTicks(5226), "Промышленный", 3.1000000000000001 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("634c7ce1-33cb-49ee-838a-80bb4e67af19"), new DateTime(2024, 10, 29, 21, 44, 49, 882, DateTimeKind.Local).AddTicks(5238), "Промышленный", 2.8999999999999999 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("6367348f-c993-479f-88ad-a23f276ba390"), new DateTime(2024, 10, 29, 18, 39, 49, 882, DateTimeKind.Local).AddTicks(5193), "Центральный", 1.5 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("63873da0-dffb-41a7-bc80-5359a165fffa"), new DateTime(2024, 10, 29, 18, 54, 49, 882, DateTimeKind.Local).AddTicks(5211), "Ленинский", 1.2 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("66754d73-b445-49a4-aa6e-8765d2dc90f5"), new DateTime(2024, 10, 29, 19, 54, 49, 882, DateTimeKind.Local).AddTicks(5224), "Культурный", 1.3999999999999999 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("6aa00f6c-b1e4-4952-89c1-e23ecb996244"), new DateTime(2024, 10, 29, 22, 39, 49, 882, DateTimeKind.Local).AddTicks(5209), "Восточный", 3.0 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("6af9470c-69ef-4788-a0ee-0ee9e9f988b0"), new DateTime(2024, 10, 29, 21, 59, 49, 882, DateTimeKind.Local).AddTicks(5218), "Московский", 2.1000000000000001 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("6d7667d4-e42a-45f9-89c0-58b636ec1fa8"), new DateTime(2024, 10, 29, 23, 39, 49, 882, DateTimeKind.Local).AddTicks(5221), "Спортивный", 1.8999999999999999 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("86430cc9-7346-4eb6-a295-10a7d6515600"), new DateTime(2024, 10, 29, 21, 24, 49, 882, DateTimeKind.Local).AddTicks(5214), "Кировский", 1.8 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("abee5e5b-dabb-4e70-88af-46fc7c7da9f6"), new DateTime(2024, 10, 29, 22, 29, 49, 882, DateTimeKind.Local).AddTicks(5227), "Гармоничный", 2.6000000000000001 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("c4a3cf83-a0c8-4b34-be34-0afcf5e427f3"), new DateTime(2024, 10, 29, 23, 4, 49, 882, DateTimeKind.Local).AddTicks(5228), "Парк", 1.3 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("c66e328b-847a-459d-8892-0e24b12507f1"), new DateTime(2024, 10, 29, 21, 39, 49, 882, DateTimeKind.Local).AddTicks(5208), "Западный", 2.5 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("c8abffed-ada1-4919-b23c-22230d96b0db"), new DateTime(2024, 10, 29, 19, 49, 49, 882, DateTimeKind.Local).AddTicks(5235), "Исторический", 3.2000000000000002 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("d89bd7d0-b4c6-4797-a47d-59a46bcea392"), new DateTime(2024, 10, 29, 20, 39, 49, 882, DateTimeKind.Local).AddTicks(5207), "Южный", 1.0 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("dcaa8ca1-6689-4517-be4b-3be9d29401ee"), new DateTime(2024, 10, 29, 21, 14, 49, 882, DateTimeKind.Local).AddTicks(5236), "Экологический", 2.7000000000000002 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "DeliveryTime", "District", "Weight" },
                values: new object[] { new Guid("f82b3597-f92f-4c40-b26d-116e60f99762"), new DateTime(2024, 10, 30, 0, 9, 49, 882, DateTimeKind.Local).AddTicks(5232), "Уютный", 2.3999999999999999 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
