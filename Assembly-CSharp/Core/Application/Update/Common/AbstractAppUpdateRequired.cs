using System;
using Il2CppDummyDll;
using UI.Windows;

namespace Core.Application.Update.Common
{
	// Token: 0x0200123A RID: 4666
	[Token(Token = "0x200123A")]
	public abstract class AbstractAppUpdateRequired : IAppUpdateOperation, IDisposable
	{
		// Token: 0x06006EBB RID: 28347
		[Token(Token = "0x6006EBB")]
		public abstract void Run();

		// Token: 0x06006EBC RID: 28348
		[Token(Token = "0x6006EBC")]
		public abstract void Stop();

		// Token: 0x06006EBD RID: 28349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EBD")]
		[Address(RVA = "0xB93D", Offset = "0xB93D", VA = "0xB93D", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x06006EBE RID: 28350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EBE")]
		[Address(RVA = "0xB93E", Offset = "0xB93E", VA = "0xB93E")]
		protected void ShowWindowAboutRequiredAppUpdate()
		{
		}

		// Token: 0x06006EBF RID: 28351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EBF")]
		[Address(RVA = "0xB93F", Offset = "0xB93F", VA = "0xB93F", Slot = "9")]
		protected virtual void ConfirmCallback(BaseDialogWindow<DialogWindow.DialogWindowArgs> window)
		{
		}

		// Token: 0x06006EC0 RID: 28352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EC0")]
		[Address(RVA = "0xB940", Offset = "0xB940", VA = "0xB940")]
		protected AbstractAppUpdateRequired()
		{
		}
	}
}
