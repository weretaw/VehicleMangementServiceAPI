using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleMangementService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    LicenseNumber = table.Column<string>(nullable: true),
                    Power = table.Column<string>(nullable: true),
                    TopSpeed = table.Column<string>(nullable: true),
                    kmPerHour = table.Column<int>(nullable: false),
                    Torque = table.Column<string>(nullable: true),
                    CO2Emissions = table.Column<string>(nullable: true),
                    EuroEmissStand = table.Column<string>(nullable: true),
                    MilesPerTank = table.Column<string>(nullable: true),
                    Height = table.Column<double>(nullable: false),
                    Wheelbase = table.Column<string>(nullable: true),
                    TurningCircile = table.Column<string>(nullable: true),
                    EngineSize = table.Column<double>(nullable: false),
                    Cylinders = table.Column<string>(nullable: true),
                    Valves = table.Column<string>(nullable: true),
                    FuelType = table.Column<string>(nullable: true),
                    Transmission = table.Column<string>(nullable: true),
                    GearBox = table.Column<string>(nullable: true),
                    Drivertrain = table.Column<string>(nullable: true),
                    Length = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
