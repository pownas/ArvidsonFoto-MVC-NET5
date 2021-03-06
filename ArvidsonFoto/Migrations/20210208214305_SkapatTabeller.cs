﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArvidsonFoto.Migrations
{
    public partial class SkapatTabeller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_gb",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GB_ID = table.Column<int>(type: "int", nullable: false),
                    GB_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GB_email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GB_homepage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GB_text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GB_date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    GB_ReadPost = table.Column<bool>(type: "bit", nullable: true),
                    GB_IP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_gb", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_images",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image_ID = table.Column<int>(type: "int", nullable: false),
                    image_huvudfamilj = table.Column<int>(type: "int", nullable: true),
                    image_familj = table.Column<int>(type: "int", nullable: true),
                    image_art = table.Column<int>(type: "int", nullable: false),
                    image_URL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    image_date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    image_description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    image_update = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_images", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_menu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    menu_ID = table.Column<int>(type: "int", nullable: false),
                    menu_mainID = table.Column<int>(type: "int", nullable: true),
                    menu_text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    menu_URLtext = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    menu_lastshowdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    menu_pagecounter = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_menu", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_PageCounter",
                columns: table => new
                {
                    PageCounter_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageCounter_Views = table.Column<int>(type: "int", nullable: false),
                    PageCounter_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PageCounter_MonthViewed = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PageCounter_LastShowDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_PageCounter", x => x.PageCounter_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_gb");

            migrationBuilder.DropTable(
                name: "tbl_images");

            migrationBuilder.DropTable(
                name: "tbl_menu");

            migrationBuilder.DropTable(
                name: "tbl_PageCounter");
        }
    }
}
