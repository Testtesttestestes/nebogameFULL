using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.Gameplay.Managers.Requirements.ListFillBehaviors;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Data.InfoRows
{
	// Token: 0x020010DB RID: 4315
	[Token(Token = "0x20010DB")]
	public abstract class AbstractInformationProvider : IInformationProvider, IDisposable
	{
		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06006508 RID: 25864 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006509 RID: 25865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001473")]
		public UserData LoggedUser
		{
			[Token(Token = "0x6006508")]
			[Address(RVA = "0xB0DF", Offset = "0xB0DF", VA = "0xB0DF", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006509")]
			[Address(RVA = "0xB0E0", Offset = "0xB0E0", VA = "0xB0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x0600650A RID: 25866 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600650B RID: 25867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001474")]
		public IListFillBehavior ListFillBehavior
		{
			[Token(Token = "0x600650A")]
			[Address(RVA = "0xB0E1", Offset = "0xB0E1", VA = "0xB0E1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600650B")]
			[Address(RVA = "0xB0E2", Offset = "0xB0E2", VA = "0xB0E2")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600650C RID: 25868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600650C")]
		[Address(RVA = "0xB0E3", Offset = "0xB0E3", VA = "0xB0E3", Slot = "7")]
		public virtual void Dispose()
		{
		}

		// Token: 0x0600650D RID: 25869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600650D")]
		[Address(RVA = "0xB0E4", Offset = "0xB0E4", VA = "0xB0E4")]
		protected AbstractInformationProvider(UserData loggedUser, [Optional] IListFillBehavior listFillBehavior)
		{
		}

		// Token: 0x0600650E RID: 25870 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600650E")]
		[Address(RVA = "0xB0E5", Offset = "0xB0E5", VA = "0xB0E5")]
		protected List<IInformationRow> Merge(List<IInformationRow> a, List<IInformationRow> b)
		{
			return null;
		}

		// Token: 0x0600650F RID: 25871 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600650F")]
		[Address(RVA = "0xB0E6", Offset = "0xB0E6", VA = "0xB0E6", Slot = "8")]
		public virtual CommonRow GetTitle(string text)
		{
			return null;
		}

		// Token: 0x06006510 RID: 25872 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006510")]
		[Address(RVA = "0xB0E7", Offset = "0xB0E7", VA = "0xB0E7", Slot = "5")]
		public List<IInformationRow> GetRows()
		{
			return null;
		}

		// Token: 0x06006511 RID: 25873
		[Token(Token = "0x6006511")]
		protected abstract void PrepareInformation();

		// Token: 0x040035FA RID: 13818
		[Token(Token = "0x40035FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected readonly List<IInformationRow> _rows;

		// Token: 0x040035FD RID: 13821
		[Token(Token = "0x40035FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		protected Dictionaries _dictionaries;
	}
}
