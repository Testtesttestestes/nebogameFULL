using System;
using System.Runtime.CompilerServices;
using Gameplay.Assistants.Control;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001141 RID: 4417
	[Token(Token = "0x2001141")]
	public class AssistantsManager : IGameManager, IBaseManager
	{
		// Token: 0x1400025E RID: 606
		// (add) Token: 0x060067A8 RID: 26536 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067A9 RID: 26537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400025E")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60067A8")]
			[Address(RVA = "0xB2D4", Offset = "0xB2D4", VA = "0xB2D4", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067A9")]
			[Address(RVA = "0xB2D5", Offset = "0xB2D5", VA = "0xB2D5", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400025F RID: 607
		// (add) Token: 0x060067AA RID: 26538 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067AB RID: 26539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400025F")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60067AA")]
			[Address(RVA = "0xB2D6", Offset = "0xB2D6", VA = "0xB2D6", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067AB")]
			[Address(RVA = "0xB2D7", Offset = "0xB2D7", VA = "0xB2D7", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x060067AC RID: 26540 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060067AD RID: 26541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001539")]
		public AssistantsController Controller
		{
			[Token(Token = "0x60067AC")]
			[Address(RVA = "0xB2D8", Offset = "0xB2D8", VA = "0xB2D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60067AD")]
			[Address(RVA = "0xB2D9", Offset = "0xB2D9", VA = "0xB2D9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060067AE RID: 26542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067AE")]
		[Address(RVA = "0xB2DA", Offset = "0xB2DA", VA = "0xB2DA", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x060067AF RID: 26543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067AF")]
		[Address(RVA = "0xB2DB", Offset = "0xB2DB", VA = "0xB2DB")]
		private void HandleInitEvent()
		{
		}

		// Token: 0x060067B0 RID: 26544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067B0")]
		[Address(RVA = "0xB2DC", Offset = "0xB2DC", VA = "0xB2DC", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x060067B1 RID: 26545 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700153A")]
		public string Name
		{
			[Token(Token = "0x60067B1")]
			[Address(RVA = "0xB2DD", Offset = "0xB2DD", VA = "0xB2DD", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060067B2 RID: 26546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067B2")]
		[Address(RVA = "0xB2DE", Offset = "0xB2DE", VA = "0xB2DE")]
		public AssistantsManager()
		{
		}
	}
}
