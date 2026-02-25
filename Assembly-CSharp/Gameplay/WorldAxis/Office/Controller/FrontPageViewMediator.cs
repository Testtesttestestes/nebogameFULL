using System;
using Gameplay.WorldAxis.Office.Events;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View.FrontPageTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.WorldAxis.Office.Controller
{
	// Token: 0x020002DD RID: 733
	[Token(Token = "0x20002DD")]
	public class FrontPageViewMediator : AbstractViewMediator<WorldAxisOfficeModel, WorldAxisOfficeEvents, WorldAxisOfficeController, FrontPageView>, IHideableMediator
	{
		// Token: 0x06001143 RID: 4419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001143")]
		[Address(RVA = "0x6340", Offset = "0x6340", VA = "0x6340")]
		public FrontPageViewMediator(WorldAxisOfficeModel model, WorldAxisOfficeEvents events, WorldAxisOfficeController controller)
		{
		}

		// Token: 0x1700028E RID: 654
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028E")]
		public override FrontPageView View
		{
			[Token(Token = "0x6001144")]
			[Address(RVA = "0x6341", Offset = "0x6341", VA = "0x6341", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001145")]
		[Address(RVA = "0x6342", Offset = "0x6342", VA = "0x6342")]
		private void Init()
		{
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001146")]
		[Address(RVA = "0x6343", Offset = "0x6343", VA = "0x6343")]
		private void HandleClanButton()
		{
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001147")]
		[Address(RVA = "0x6344", Offset = "0x6344", VA = "0x6344")]
		private void ToWorldAxisButtonClickedEventHandler()
		{
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001148")]
		[Address(RVA = "0x6345", Offset = "0x6345", VA = "0x6345")]
		private void CreateClanButtonClickedEventHandler()
		{
		}

		// Token: 0x1700028F RID: 655
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028F")]
		public override WorldAxisOfficeEvents Events
		{
			[Token(Token = "0x6001149")]
			[Address(RVA = "0x6346", Offset = "0x6346", VA = "0x6346", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114A")]
		[Address(RVA = "0x6347", Offset = "0x6347", VA = "0x6347")]
		private void ClanStatusChangedEventHandler()
		{
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114B")]
		[Address(RVA = "0x6348", Offset = "0x6348", VA = "0x6348")]
		private void ScheduleChangedEventHandler()
		{
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114C")]
		[Address(RVA = "0x6349", Offset = "0x6349", VA = "0x6349", Slot = "21")]
		public void Hide()
		{
		}
	}
}
