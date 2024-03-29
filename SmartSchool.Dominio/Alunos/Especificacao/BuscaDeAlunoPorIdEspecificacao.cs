﻿using SmartSchool.Comum.Especificao;
using System;
using System.Linq.Expressions;

namespace SmartSchool.Dominio.Alunos.Especificacao
{
	public class BuscaDeAlunoPorIdEspecificacao : Especificacao<Aluno>
	{
		private readonly Guid _id;

		public BuscaDeAlunoPorIdEspecificacao(Guid id) => this._id = id;

		public override Expression<Func<Aluno, bool>> ExpressaoEspecificacao => x => x.ID == this._id;
	}
}
