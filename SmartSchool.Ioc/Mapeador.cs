using AutoMapper;
using SmartSchool.Comum.Dominio;
using System.Collections.Generic;

namespace SmartSchool.Ioc
{
    public static class Mapeador
    {
        private static IMapper autoMapper = ConfiguracaoAutoMap.Inicializar().CreateMapper();

        public static TRetorno MapearParaDto<TRetorno>(this IEntidade objeto)
        {
            return autoMapper.Map<TRetorno>(objeto);
            // return Mapper.Map<TRetorno>(objeto);
        }

        public static IEnumerable<TRetorno> MapearParaDto<TRetorno>(this IEnumerable<IEntidade> objeto)
        {
            return autoMapper.Map<IEnumerable<TRetorno>>(objeto);
        }

        public static TRetorno MapearParaDominio<TRetorno>(this object objeto) where TRetorno : IEntidade
        {
            return autoMapper.Map<TRetorno>(objeto);
        }

        public static IEnumerable<TRetorno> MapearParaDominio<TRetorno>(this IEnumerable<object> objeto) where TRetorno : IEntidade
        {
            return autoMapper.Map<IEnumerable<TRetorno>>(objeto);
        }
    }
}
