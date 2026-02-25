using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.AboutClansTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A64 RID: 2660
	[Token(Token = "0x2000A64")]
	public class AboutClansViewMediator : AbstractViewMediator<ClanOfficeModel, ClanOfficeEvents, ClanOfficeController, AboutClansView>, IHideableMediator
	{
		// Token: 0x06003ED6 RID: 16086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED6")]
		[Address(RVA = "0x8D92", Offset = "0x8D92", VA = "0x8D92")]
		public AboutClansViewMediator(ClanOfficeModel model, ClanOfficeEvents events, ClanOfficeController controller)
		{
		}

		// Token: 0x17000C98 RID: 3224
		// (set) Token: 0x06003ED7 RID: 16087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C98")]
		public override AboutClansView View
		{
			[Token(Token = "0x6003ED7")]
			[Address(RVA = "0x8D93", Offset = "0x8D93", VA = "0x8D93", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED8")]
		[Address(RVA = "0x8D94", Offset = "0x8D94", VA = "0x8D94")]
		private void CreateClanButtonClickedEventHandler()
		{
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED9")]
		[Address(RVA = "0x8D95", Offset = "0x8D95", VA = "0x8D95")]
		private void FindClanButtonClickedEventHandler()
		{
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDA")]
		[Address(RVA = "0x8D96", Offset = "0x8D96", VA = "0x8D96", Slot = "21")]
		public void Hide()
		{
		}
	}
}
