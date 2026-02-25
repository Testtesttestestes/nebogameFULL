using System;
using Gameplay.AccountLinker.ProgressSaver.Model;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Gameplay.AccountLinker.ProgressSaver.Controller
{
	// Token: 0x02000E0E RID: 3598
	[Token(Token = "0x2000E0E")]
	public abstract class BaseProgressSaverEnterPointViewMediator<TView> : AbstractViewMediator<ProgressSaverModel, ProgressSaverEvents, ProgressSaverController, TView> where TView : Component
	{
		// Token: 0x060057A2 RID: 22434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A2")]
		public override void Dispose()
		{
		}

		// Token: 0x060057A3 RID: 22435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A3")]
		public BaseProgressSaverEnterPointViewMediator(ProgressSaverModel model, ProgressSaverEvents events, ProgressSaverController controller)
		{
		}

		// Token: 0x170011E9 RID: 4585
		// (set) Token: 0x060057A4 RID: 22436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011E9")]
		public override TView View
		{
			[Token(Token = "0x60057A4")]
			set
			{
			}
		}

		// Token: 0x060057A5 RID: 22437
		[Token(Token = "0x60057A5")]
		protected abstract void ResetView();

		// Token: 0x060057A6 RID: 22438
		[Token(Token = "0x60057A6")]
		protected abstract void SetupView();

		// Token: 0x060057A7 RID: 22439
		[Token(Token = "0x60057A7")]
		protected abstract void ValidateShowProgressButton();

		// Token: 0x060057A8 RID: 22440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A8")]
		public void ShowProgressSaverWindow()
		{
		}

		// Token: 0x060057A9 RID: 22441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057A9")]
		protected void CloseProgressSaverWindow()
		{
		}
	}
}
