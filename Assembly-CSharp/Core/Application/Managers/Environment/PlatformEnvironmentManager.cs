using System;
using System.Runtime.CompilerServices;
using Gameplay.Billing.BillingProvider.UnityIAP;
using Il2CppDummyDll;

namespace Core.Application.Managers.Environment
{
	// Token: 0x02001262 RID: 4706
	[Token(Token = "0x2001262")]
	public class PlatformEnvironmentManager : IAppManager, IBaseManager, IDisposable, IEnvironment
	{
		// Token: 0x140002F3 RID: 755
		// (add) Token: 0x06006F85 RID: 28549 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F86 RID: 28550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F3")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006F85")]
			[Address(RVA = "0xB9E7", Offset = "0xB9E7", VA = "0xB9E7", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F86")]
			[Address(RVA = "0xB9E8", Offset = "0xB9E8", VA = "0xB9E8", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002F4 RID: 756
		// (add) Token: 0x06006F87 RID: 28551 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F88 RID: 28552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F4")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006F87")]
			[Address(RVA = "0xB9E9", Offset = "0xB9E9", VA = "0xB9E9", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F88")]
			[Address(RVA = "0xB9EA", Offset = "0xB9EA", VA = "0xB9EA", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006F89 RID: 28553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F89")]
		[Address(RVA = "0xB9EB", Offset = "0xB9EB", VA = "0xB9EB")]
		public PlatformEnvironmentManager(IApp app)
		{
		}

		// Token: 0x06006F8A RID: 28554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F8A")]
		[Address(RVA = "0xB9EC", Offset = "0xB9EC", VA = "0xB9EC", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006F8B RID: 28555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F8B")]
		[Address(RVA = "0xB9ED", Offset = "0xB9ED", VA = "0xB9ED")]
		private void ImplementationOnInitCompleteEvent(IBaseManager manager)
		{
		}

		// Token: 0x06006F8C RID: 28556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F8C")]
		[Address(RVA = "0xB9EE", Offset = "0xB9EE", VA = "0xB9EE")]
		private void ImplementationOnDeinitCompleteEvent(IBaseManager manager)
		{
		}

		// Token: 0x06006F8D RID: 28557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F8D")]
		[Address(RVA = "0xB9EF", Offset = "0xB9EF", VA = "0xB9EF", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06006F8E RID: 28558 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016C3")]
		public string Name
		{
			[Token(Token = "0x6006F8E")]
			[Address(RVA = "0xB9F0", Offset = "0xB9F0", VA = "0xB9F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006F8F RID: 28559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F8F")]
		[Address(RVA = "0xB9F1", Offset = "0xB9F1", VA = "0xB9F1", Slot = "11")]
		public void Dispose()
		{
		}

		// Token: 0x06006F90 RID: 28560 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006F90")]
		public T GetUiapWrapper<T>() where T : class, IUiapWrapper, new()
		{
			return null;
		}

		// Token: 0x04003A43 RID: 14915
		[Token(Token = "0x4003A43")]
		[FieldOffset(Offset = "0x10")]
		private IAppManager _implementation;
	}
}
