using System;
using Il2CppDummyDll;

namespace UI.Windows
{
	// Token: 0x0200026B RID: 619
	[Token(Token = "0x200026B")]
	public abstract class BaseWindow<T> : BaseWindow where T : BaseWindowArgs
	{
		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020A")]
		public new T WindowArgs
		{
			[Token(Token = "0x6000EE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EE9")]
			set
			{
			}
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EEA")]
		protected override void OnShow(BaseWindowArgs args)
		{
		}

		// Token: 0x06000EEB RID: 3819
		[Token(Token = "0x6000EEB")]
		protected abstract void OnShow(T args);

		// Token: 0x06000EEC RID: 3820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EEC")]
		protected BaseWindow()
		{
		}
	}
}
