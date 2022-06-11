using Microsoft.EntityFrameworkCore.Migrations;

namespace Travelland.Repository.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OfferInUserReservations",
                table: "OfferInUserReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfferInReservation",
                table: "OfferInReservation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfferInUserReservations",
                table: "OfferInUserReservations",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfferInReservation",
                table: "OfferInReservation",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OfferInUserReservations",
                table: "OfferInUserReservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfferInReservation",
                table: "OfferInReservation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfferInUserReservations",
                table: "OfferInUserReservations",
                columns: new[] { "id", "UserReservationsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfferInReservation",
                table: "OfferInReservation",
                columns: new[] { "id", "ReservationId" });
        }
    }
}
