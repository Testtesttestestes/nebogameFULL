using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Application.Managers
{
	// Token: 0x0200125F RID: 4703
	[Token(Token = "0x200125F")]
	public class UnityServicesManager : IAppManager, IBaseManager
	{
		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06006F7A RID: 28538 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016C2")]
		public string Name
		{
			[Token(Token = "0x6006F7A")]
			[Address(RVA = "0xB9DE", Offset = "0xB9DE", VA = "0xB9DE", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002F1 RID: 753
		// (add) Token: 0x06006F7B RID: 28539 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F7C RID: 28540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F1")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006F7B")]
			[Address(RVA = "0xB9DF", Offset = "0xB9DF", VA = "0xB9DF", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F7C")]
			[Address(RVA = "0xB9E0", Offset = "0xB9E0", VA = "0xB9E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002F2 RID: 754
		// (add) Token: 0x06006F7D RID: 28541 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F7E RID: 28542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F2")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006F7D")]
			[Address(RVA = "0xB9E1", Offset = "0xB9E1", VA = "0xB9E1", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F7E")]
			[Address(RVA = "0xB9E2", Offset = "0xB9E2", VA = "0xB9E2", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F7F")]
		[Address(RVA = "0xB9E3", Offset = "0xB9E3", VA = "0xB9E3", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006F80 RID: 28544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F80")]
		[Address(RVA = "0xB9E4", Offset = "0xB9E4", VA = "0xB9E4", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006F81 RID: 28545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F81")]
		[Address(RVA = "0xB9E5", Offset = "0xB9E5", VA = "0xB9E5")]
		public UnityServicesManager()
		{
		}
	}
}
