using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Travelland.Repository.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfferInReservation_Reservation_ReservationId",
                table: "OfferInReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_OfferInReservation_Offers_id",
                table: "OfferInReservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_AspNetUsers_ClientId",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfferInReservation",
                table: "OfferInReservation");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "Reservations");

            migrationBuilder.RenameTable(
                name: "OfferInReservation",
                newName: "OfferInReservations");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_ClientId",
                table: "Reservations",
                newName: "IX_Reservations_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_OfferInReservation_ReservationId",
                table: "OfferInReservations",
                newName: "IX_OfferInReservations_ReservationId");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OfferInReservations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfferInReservations",
                table: "OfferInReservations",
                column: "id");

            migrationBuilder.CreateTable(
                name: "EmailMessages",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    MailTo = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailMessages", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OfferInReservations_Reservations_ReservationId",
                table: "OfferInReservations",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OfferInReservations_Offers_id",
                table: "OfferInReservations",
                column: "id",
                principalTable: "Offers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_ClientId",
                table: "Reservations",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OfferInReservations_Reservations_ReservationId",
                table: "OfferInReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_OfferInReservations_Offers_id",
                table: "OfferInReservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_ClientId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "EmailMessages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OfferInReservations",
                table: "OfferInReservations");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OfferInReservations");

            migrationBuilder.RenameTable(
                name: "Reservations",
                newName: "Reservation");

            migrationBuilder.RenameTable(
                name: "OfferInReservations",
                newName: "OfferInReservation");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_ClientId",
                table: "Reservation",
                newName: "IX_Reservation_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_OfferInReservations_ReservationId",
                table: "OfferInReservation",
                newName: "IX_OfferInReservation_ReservationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OfferInReservation",
                table: "OfferInReservation",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_OfferInReservation_Reservation_ReservationId",
                table: "OfferInReservation",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OfferInReservation_Offers_id",
                table: "OfferInReservation",
                column: "id",
                principalTable: "Offers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_AspNetUsers_ClientId",
                table: "Reservation",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
