using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Application.Managers
{
	// Token: 0x0200124A RID: 4682
	[Token(Token = "0x200124A")]
	public class AnimationSupportManager : IAppManager, IBaseManager
	{
		// Token: 0x140002E2 RID: 738
		// (add) Token: 0x06006EED RID: 28397 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006EEE RID: 28398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002E2")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006EED")]
			[Address(RVA = "0xB96B", Offset = "0xB96B", VA = "0xB96B", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006EEE")]
			[Address(RVA = "0xB96C", Offset = "0xB96C", VA = "0xB96C", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002E3 RID: 739
		// (add) Token: 0x06006EEF RID: 28399 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006EF0 RID: 28400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002E3")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006EEF")]
			[Address(RVA = "0xB96D", Offset = "0xB96D", VA = "0xB96D", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006EF0")]
			[Address(RVA = "0xB96E", Offset = "0xB96E", VA = "0xB96E", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006EF1 RID: 28401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EF1")]
		[Address(RVA = "0xB96F", Offset = "0xB96F", VA = "0xB96F", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006EF2 RID: 28402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EF2")]
		[Address(RVA = "0xB970", Offset = "0xB970", VA = "0xB970", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06006EF3 RID: 28403 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016AA")]
		public string Name
		{
			[Token(Token = "0x6006EF3")]
			[Address(RVA = "0xB971", Offset = "0xB971", VA = "0xB971", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006EF4 RID: 28404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EF4")]
		[Address(RVA = "0xB972", Offset = "0xB972", VA = "0xB972")]
		public AnimationSupportManager()
		{
		}
	}
}
