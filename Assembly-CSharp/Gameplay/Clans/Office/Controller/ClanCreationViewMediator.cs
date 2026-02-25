using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.ClanCreationTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Consts;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A65 RID: 2661
	[Token(Token = "0x2000A65")]
	public class ClanCreationViewMediator : AbstractViewMediator<ClanOfficeModel, ClanOfficeEvents, ClanOfficeController, ClanCreationView>, IHideableMediator
	{
		// Token: 0x06003EDB RID: 16091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDB")]
		[Address(RVA = "0x8D97", Offset = "0x8D97", VA = "0x8D97")]
		public ClanCreationViewMediator(ClanOfficeModel model, ClanOfficeEvents events, ClanOfficeController controller)
		{
		}

		// Token: 0x17000C99 RID: 3225
		// (set) Token: 0x06003EDC RID: 16092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C99")]
		public override ClanCreationView View
		{
			[Token(Token = "0x6003EDC")]
			[Address(RVA = "0x8D98", Offset = "0x8D98", VA = "0x8D98", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003EDD RID: 16093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDD")]
		[Address(RVA = "0x8D99", Offset = "0x8D99", VA = "0x8D99")]
		private void Init()
		{
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDE")]
		[Address(RVA = "0x8D9A", Offset = "0x8D9A", VA = "0x8D9A")]
		private void CreateClanButtonClickedEventHandler()
		{
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EDF")]
		[Address(RVA = "0x8D9B", Offset = "0x8D9B", VA = "0x8D9B")]
		private void FractionCultClanClickedEventHandler(ClanTypeListElement element)
		{
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE0")]
		[Address(RVA = "0x8D9C", Offset = "0x8D9C", VA = "0x8D9C")]
		private void PlayerCultClanClickedEventHandler(ClanTypeListElement element)
		{
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE1")]
		[Address(RVA = "0x8D9D", Offset = "0x8D9D", VA = "0x8D9D")]
		private void SelectFractionClan()
		{
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE2")]
		[Address(RVA = "0x8D9E", Offset = "0x8D9E", VA = "0x8D9E")]
		private void SelectPlayerClan()
		{
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EE3")]
		[Address(RVA = "0x8D9F", Offset = "0x8D9F", VA = "0x8D9F", Slot = "21")]
		public void Hide()
		{
		}

		// Token: 0x0400237B RID: 9083
		[Token(Token = "0x400237B")]
		[FieldOffset(Offset = "0x18")]
		private ClanFlags _fractionFlag;
	}
}
