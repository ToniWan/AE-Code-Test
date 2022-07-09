using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AE_Code_Test_API.Migrations
{
    public partial class _1_0_0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Port",
                columns: table => new
                {
                    PortId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Port", x => x.PortId);
                });

            migrationBuilder.CreateTable(
                name: "Ship",
                columns: table => new
                {
                    ShipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    VelocityKmh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ship", x => x.ShipId);
                });

            migrationBuilder.InsertData(
                table: "Port",
                columns: new[] { "PortId", "CreateDate", "Latitude", "Longitude", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1280), -17.375094893872074, 64.813785519925574, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1293), "Port1" },
                    { 2, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1315), 52.828049005762864, -105.65597772252674, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1316), "Port2" },
                    { 3, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1318), 58.350533142905505, 153.53914153465064, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1319), "Port3" },
                    { 4, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1323), 19.544001131766578, -140.91694014506194, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1323), "Port4" },
                    { 5, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1325), 40.199608247573565, 138.05132866272197, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1326), "Port5" },
                    { 6, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1331), 37.776125603431154, 98.330554994108979, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1331), "Port6" },
                    { 7, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1334), -82.928884659401731, 81.197981161304597, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1334), "Port7" },
                    { 8, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1337), -81.192463109940604, 75.647680491294409, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1338), "Port8" },
                    { 9, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1340), -7.8098116361208128, 29.508601305324731, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1340), "Port9" },
                    { 10, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1345), 26.610538158517599, -159.08454759663209, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1346), "Port10" },
                    { 11, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1348), 65.6455047223169, 25.917608935325489, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1349), "Port11" },
                    { 12, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1352), 50.783112224694463, 103.77230367615374, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1353), "Port12" },
                    { 13, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1355), -5.5385125438267266, 93.823584150209683, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1355), "Port13" },
                    { 14, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1359), -77.735361638272934, -179.77986971346235, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1359), "Port14" },
                    { 15, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1361), -13.538906344575992, 153.26884864349853, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1361), "Port15" },
                    { 16, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1365), -74.897328462678502, -64.801723928084897, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1365), "Port16" },
                    { 17, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1367), 81.426047900640782, 67.065835676266261, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1367), "Port17" },
                    { 18, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1372), -24.021020038184048, -75.716057008991271, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1373), "Port18" },
                    { 19, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1375), -23.78312019719715, -123.02849704466301, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1375), "Port19" },
                    { 20, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1379), 56.29908757353752, 7.8900441858908721, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1379), "Port20" },
                    { 21, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1381), 32.140673062789702, 162.25419101302697, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1382), "Port21" },
                    { 22, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1385), 20.569412542179194, 78.469058686475705, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1386), "Port22" },
                    { 23, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1388), -67.502403065252111, -129.84506870225187, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1388), "Port23" },
                    { 24, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1391), -41.969275623802268, -90.712365130010255, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1392), "Port24" },
                    { 25, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1394), -33.349117799323004, -153.79880065405217, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1394), "Port25" },
                    { 26, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1433), -45.586422592074776, -84.107663339996861, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1433), "Port26" },
                    { 27, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1436), -89.757369502250683, -39.595365380428206, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1436), "Port27" },
                    { 28, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1440), -32.338975080649163, -143.5196888179164, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1441), "Port28" },
                    { 29, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1443), 33.509224000098044, 29.387282054795918, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1443), "Port29" },
                    { 30, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1446), -69.566168956570337, -145.50646781813802, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1447), "Port30" },
                    { 31, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1449), 70.675264026159624, -146.96860872814364, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1449), "Port31" },
                    { 32, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1452), -1.4049433510576108, -152.28076160345117, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1453), "Port32" },
                    { 33, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1455), 74.969838454385155, -149.90789783791018, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1455), "Port33" },
                    { 34, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1460), -67.017953249010361, -63.459276194018557, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1460), "Port34" },
                    { 35, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1463), -38.769647964687316, -112.36102578413528, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1463), "Port35" },
                    { 36, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1466), 21.989464564021844, -75.669266455501258, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1467), "Port36" },
                    { 37, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1469), 49.854774375416525, 162.13780547916463, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1469), "Port37" },
                    { 38, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1472), 22.69544467305596, -122.7095513030163, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1473), "Port38" },
                    { 39, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1475), -28.686935409173017, 75.879697187817925, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1475), "Port39" },
                    { 40, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1479), -36.842684619971465, -73.028303901892542, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1479), "Port40" },
                    { 41, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1481), 18.465712935269352, 150.9541777253279, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1482), "Port41" },
                    { 42, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1485), -58.2501390739111, 67.169399852253662, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1485), "Port42" }
                });

            migrationBuilder.InsertData(
                table: "Port",
                columns: new[] { "PortId", "CreateDate", "Latitude", "Longitude", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 43, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1487), 54.373802623079627, -75.113315843304264, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1488), "Port43" },
                    { 44, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1491), -88.180090162238486, -55.342058695356585, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1491), "Port44" },
                    { 45, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1493), -68.458162614936981, 63.527684292998487, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1493), "Port45" },
                    { 46, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1497), -51.806535382855593, -2.6842391475284444, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1497), "Port46" },
                    { 47, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1499), -11.887189590648219, -36.026864807001743, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1499), "Port47" },
                    { 48, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1502), -71.781980194889528, -3.1309083830570046, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1503), "Port48" },
                    { 49, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1505), -61.305689537417464, -149.34819782905836, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1505), "Port49" },
                    { 50, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1508), 83.432349072023527, -134.02364504348279, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1509), "Port50" },
                    { 51, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1511), -18.004187889972826, -139.26570607184118, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1511), "Port51" },
                    { 52, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1514), -28.139297687130195, 89.946826092583706, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1514), "Port52" },
                    { 53, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1538), -72.547033777522074, -130.71693945440938, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1538), "Port53" },
                    { 54, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1543), -9.1429885074365842, -101.76729643158068, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1543), "Port54" },
                    { 55, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1545), -61.805371212033172, -167.27166351056988, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1546), "Port55" },
                    { 56, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1549), -19.93232453114058, 50.557354728974275, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1549), "Port56" },
                    { 57, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1552), -34.697994055458736, -87.202914363071713, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1552), "Port57" },
                    { 58, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1555), 48.448651559887224, -3.0303745780889244, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1555), "Port58" },
                    { 59, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1557), 68.589718564963903, -105.0975134287857, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1558), "Port59" },
                    { 60, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1561), 66.257037120184521, -27.687736174291302, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1561), "Port60" },
                    { 61, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1563), 19.318474633064227, 148.63960339723707, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1564), "Port61" },
                    { 62, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1568), 45.650279816687373, -81.113073285287129, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1568), "Port62" },
                    { 63, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1570), 35.277733793545821, -144.09399499821609, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1570), "Port63" },
                    { 64, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1574), -79.17619553407836, 42.712134545968695, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1574), "Port64" },
                    { 65, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1576), 6.6102714821271604, 116.16478033653902, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1577), "Port65" },
                    { 66, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1582), 38.108774609553194, 179.50642139773083, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1582), "Port66" },
                    { 67, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1584), 32.11574077595921, -156.14052462655849, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1585), "Port67" },
                    { 68, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1588), -62.317213339862874, 63.141587603878094, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1589), "Port68" },
                    { 69, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1591), 4.3471417921398938, 10.537014746733831, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1591), "Port69" },
                    { 70, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1594), -38.334026513722833, -160.31067400329633, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1595), "Port70" },
                    { 71, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1597), 28.097799144322892, -52.713730318599048, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1597), "Port71" },
                    { 72, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1600), 75.737282062147273, 78.601805565052985, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1601), "Port72" },
                    { 73, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1603), 66.582337289062934, -57.078337069853461, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1603), "Port73" },
                    { 74, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1606), -13.887925170498505, 157.25155471879987, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1607), "Port74" },
                    { 75, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1608), 82.569627546559843, -55.304374295120937, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1609), "Port75" },
                    { 76, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1612), 16.677283553542054, 34.669632133694051, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1612), "Port76" },
                    { 77, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1614), -44.792671492969987, 83.224077444462296, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1615), "Port77" },
                    { 78, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1618), 54.596544946752488, 41.348187704319173, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1618), "Port78" },
                    { 79, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1642), -89.212004011592228, 101.9936811625758, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1642), "Port79" },
                    { 80, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1646), 25.133555192971784, -170.77405255581249, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1646), "Port80" },
                    { 81, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1648), 55.755996292995519, -136.38972405142209, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1649), "Port81" },
                    { 82, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1652), -87.686581898332733, 88.068370575704478, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1652), "Port82" },
                    { 83, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1654), 61.960100808027619, 17.244878981721342, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1655), "Port83" },
                    { 84, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1658), -41.00930890621418, 48.40398849013738, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1658), "Port84" }
                });

            migrationBuilder.InsertData(
                table: "Port",
                columns: new[] { "PortId", "CreateDate", "Latitude", "Longitude", "ModifyDate", "Name" },
                values: new object[,]
                {
                    { 85, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1660), -27.382471782754912, -94.497182421009143, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1661), "Port85" },
                    { 86, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1664), 84.330290965151022, -40.722083102205545, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1664), "Port86" },
                    { 87, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1667), 72.00668908088582, -129.84851963629089, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1667), "Port87" },
                    { 88, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1671), -66.647562097223272, 119.30411146360785, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1671), "Port88" },
                    { 89, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1673), -54.508279312233583, 117.84792949385911, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1673), "Port89" },
                    { 90, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1676), 49.945080258232792, 22.956327002384484, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1677), "Port90" },
                    { 91, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1679), 67.036838625655861, 12.372517592177388, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1679), "Port91" },
                    { 92, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1682), -40.769891142045239, -87.799270937136853, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1683), "Port92" },
                    { 93, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1684), -6.1063054803812804, -142.22080643673326, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1685), "Port93" },
                    { 94, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1688), -12.797521981436432, -100.04798213735316, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1688), "Port94" },
                    { 95, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1690), -3.1761643958206633, -6.4439283305517563, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1691), "Port95" },
                    { 96, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1694), 46.834048135438536, 71.181620558335737, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1694), "Port96" },
                    { 97, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1696), -49.698664883152354, 33.779923874213011, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1696), "Port97" },
                    { 98, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1700), -13.095410207427719, 169.8315154325162, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1700), "Port98" },
                    { 99, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1702), 64.413000776726392, 25.765547340329505, new DateTime(2022, 7, 8, 22, 43, 57, 897, DateTimeKind.Local).AddTicks(1702), "Port99" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Port");

            migrationBuilder.DropTable(
                name: "Ship");
        }
    }
}
