using System;
using System.Collections.Generic;
using Gameplay.GameEvents.Model.Tags.Factories;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GameEvents.Model.Tags.Repo
{
	// Token: 0x020007BE RID: 1982
	[Token(Token = "0x20007BE")]
	public class MetaTagFactoriesRepository : IMetaTagFactoriesRepository, IDisposable
	{
		// Token: 0x06002EC1 RID: 11969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC1")]
		[Address(RVA = "0x7F39", Offset = "0x7F39", VA = "0x7F39")]
		public void Add(IMetaTagFactory factory)
		{
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x000096A8 File Offset: 0x000078A8
		[Token(Token = "0x6002EC2")]
		[Address(RVA = "0x7F3A", Offset = "0x7F3A", VA = "0x7F3A", Slot = "4")]
		public bool TryGetFactory(EventTagDic.Types.Tag id, out IMetaTagFactory factory)
		{
			return default(bool);
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x000096C0 File Offset: 0x000078C0
		[Token(Token = "0x6002EC3")]
		[Address(RVA = "0x7F3B", Offset = "0x7F3B", VA = "0x7F3B", Slot = "5")]
		public bool TryGetFactory(EventTagDic.Types.Tag[] ids, out List<IMetaTagFactory> factories)
		{
			return default(bool);
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC4")]
		[Address(RVA = "0x7F3C", Offset = "0x7F3C", VA = "0x7F3C", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC5")]
		[Address(RVA = "0x7F3D", Offset = "0x7F3D", VA = "0x7F3D")]
		public MetaTagFactoriesRepository()
		{
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC6")]
		[Address(RVA = "0x7F3E", Offset = "0x7F3E", VA = "0x7F3E")]
		protected void Init()
		{
		}

		// Token: 0x0400199E RID: 6558
		[Token(Token = "0x400199E")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<EventTagDic.Types.Tag, IMetaTagFactory> _factories;
	}
}
