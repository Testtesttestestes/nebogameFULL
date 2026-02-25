using System;
using Core.Gameplay;
using Gameplay.UserInterface.View.Update;
using Il2CppDummyDll;
using UI;
using UI.Windows;

namespace Core.Application.Update.Common
{
	// Token: 0x02001239 RID: 4665
	[Token(Token = "0x2001239")]
	public abstract class AbstractAppUpdateRecommended : IAppUpdateOperation, IDisposable
	{
		// Token: 0x06006EB5 RID: 28341
		[Token(Token = "0x6006EB5")]
		public abstract void Run();

		// Token: 0x06006EB6 RID: 28342
		[Token(Token = "0x6006EB6")]
		public abstract void Stop();

		// Token: 0x06006EB7 RID: 28343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EB7")]
		[Address(RVA = "0xB939", Offset = "0xB939", VA = "0xB939", Slot = "9")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06006EB8 RID: 28344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EB8")]
		[Address(RVA = "0xB93A", Offset = "0xB93A", VA = "0xB93A")]
		public AbstractAppUpdateRecommended(IApp app, IAuthDataProvider authDataProvider, RecommendedAppUpdateView entryPointView, IProgress progressView)
		{
		}

		// Token: 0x06006EB9 RID: 28345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EB9")]
		[Address(RVA = "0xB93B", Offset = "0xB93B", VA = "0xB93B")]
		protected void ShowWindowAboutRecommendedAppUpdate()
		{
		}

		// Token: 0x06006EBA RID: 28346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EBA")]
		[Address(RVA = "0xB93C", Offset = "0xB93C", VA = "0xB93C", Slot = "10")]
		protected virtual void ConfirmAboutRecommendedAppUpdateCallback(BaseDialogWindow<DialogWindow.DialogWindowArgs> window)
		{
		}

		// Token: 0x040039D7 RID: 14807
		[Token(Token = "0x40039D7")]
		[FieldOffset(Offset = "0x8")]
		protected IApp _app;

		// Token: 0x040039D8 RID: 14808
		[Token(Token = "0x40039D8")]
		[FieldOffset(Offset = "0xC")]
		protected IAuthDataProvider _authDataProvider;

		// Token: 0x040039D9 RID: 14809
		[Token(Token = "0x40039D9")]
		[FieldOffset(Offset = "0x10")]
		protected IProgress _progressView;

		// Token: 0x040039DA RID: 14810
		[Token(Token = "0x40039DA")]
		[FieldOffset(Offset = "0x14")]
		protected RecommendedAppUpdateView _entryPointView;
	}
}
