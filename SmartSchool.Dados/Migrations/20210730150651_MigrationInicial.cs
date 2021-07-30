using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.Dados.Migrations
{
    public partial class MigrationInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "SmartSchool");

            migrationBuilder.CreateTable(
                name: "ALUNO",
                schema: "SmartSchool",
                columns: table => new
                {
                    USUA_ID_USUARIO = table.Column<int>(nullable: false),
                    Matricula = table.Column<int>(nullable: false),
                    USUA_NM_NOME = table.Column<string>(maxLength: 32, nullable: false),
                    USUA_NM_SOBRENOME = table.Column<string>(maxLength: 128, nullable: false),
                    USUA_NR_TELEFONE = table.Column<string>(maxLength: 16, nullable: true),
                    USUA_DT_NASCIMENTO = table.Column<DateTime>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    USUA_IN_ATIVO = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ALUNO", x => x.USUA_ID_USUARIO);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                schema: "SmartSchool",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                schema: "SmartSchool",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalSchema: "SmartSchool",
                        principalTable: "Professores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunoDisciplina",
                schema: "SmartSchool",
                columns: table => new
                {
                    AlunoId = table.Column<int>(nullable: false),
                    DisciplinaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoDisciplina", x => new { x.AlunoId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_AlunoDisciplina_ALUNO_AlunoId",
                        column: x => x.AlunoId,
                        principalSchema: "SmartSchool",
                        principalTable: "ALUNO",
                        principalColumn: "USUA_ID_USUARIO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoDisciplina_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalSchema: "SmartSchool",
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "SmartSchool",
                table: "ALUNO",
                columns: new[] { "USUA_ID_USUARIO", "USUA_IN_ATIVO", "DataFim", "DataInicio", "USUA_DT_NASCIMENTO", "Matricula", "USUA_NM_NOME", "USUA_NM_SOBRENOME", "USUA_NR_TELEFONE" },
                values: new object[,]
                {
                    { 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Marta", "Kent", "33225555" },
                    { 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Paula", "Isabela", "3354288" },
                    { 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Laura", "Antonia", "55668899" },
                    { 4, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Luiza", "Maria", "6565659" },
                    { 5, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Lucas", "Machado", "565685415" },
                    { 6, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Pedro", "Alvares", "456454545" },
                    { 7, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Paulo", "José", "9874512" }
                });

            migrationBuilder.InsertData(
                schema: "SmartSchool",
                table: "Professores",
                columns: new[] { "ID", "Nome" },
                values: new object[,]
                {
                    { 1, "Lauro" },
                    { 2, "Roberto" },
                    { 3, "Ronaldo" },
                    { 4, "Rodrigo" },
                    { 5, "Alexandre" }
                });

            migrationBuilder.InsertData(
                schema: "SmartSchool",
                table: "Disciplinas",
                columns: new[] { "Id", "Nome", "ProfessorId" },
                values: new object[,]
                {
                    { 1, "Matemática", 1 },
                    { 2, "Física", 2 },
                    { 3, "Português", 3 },
                    { 4, "Inglês", 4 },
                    { 5, "Programação", 5 }
                });

            migrationBuilder.InsertData(
                schema: "SmartSchool",
                table: "AlunoDisciplina",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 4, 5 },
                    { 2, 5 },
                    { 1, 5 },
                    { 7, 4 },
                    { 6, 4 },
                    { 5, 4 },
                    { 4, 4 },
                    { 1, 4 },
                    { 7, 3 },
                    { 5, 5 },
                    { 6, 3 },
                    { 7, 2 },
                    { 6, 2 },
                    { 3, 2 },
                    { 2, 2 },
                    { 1, 2 },
                    { 7, 1 },
                    { 6, 1 },
                    { 4, 1 },
                    { 3, 1 },
                    { 3, 3 },
                    { 7, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunoDisciplina_DisciplinaId",
                schema: "SmartSchool",
                table: "AlunoDisciplina",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProfessorId",
                schema: "SmartSchool",
                table: "Disciplinas",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoDisciplina",
                schema: "SmartSchool");

            migrationBuilder.DropTable(
                name: "ALUNO",
                schema: "SmartSchool");

            migrationBuilder.DropTable(
                name: "Disciplinas",
                schema: "SmartSchool");

            migrationBuilder.DropTable(
                name: "Professores",
                schema: "SmartSchool");
        }
    }
}
