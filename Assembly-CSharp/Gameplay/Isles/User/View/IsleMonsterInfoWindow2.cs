using System;
using Gameplay.Isles.User.Controller;
using Il2CppDummyDll;
using UI.Wiki;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D1D RID: 3357
	[Token(Token = "0x2000D1D")]
	public class IsleMonsterInfoWindow2 : WindowWhitCloseButton<AttackMonsterWindowArgs>
	{
		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x060051F9 RID: 20985 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001095")]
		public override string WindowId
		{
			[Token(Token = "0x60051F9")]
			[Address(RVA = "0x9FD0", Offset = "0x9FD0", VA = "0x9FD0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x060051FA RID: 20986 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001096")]
		public WikiUriRouter Wiki
		{
			[Token(Token = "0x60051FA")]
			[Address(RVA = "0x9FD1", Offset = "0x9FD1", VA = "0x9FD1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x060051FB RID: 20987 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001097")]
		public MonsterInfoView2 MonsterInfoView
		{
			[Token(Token = "0x60051FB")]
			[Address(RVA = "0x9FD2", Offset = "0x9FD2", VA = "0x9FD2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x060051FC RID: 20988 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		[Token(Token = "0x17001098")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x60051FC")]
			[Address(RVA = "0x9FD3", Offset = "0x9FD3", VA = "0x9FD3", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051FD")]
		[Address(RVA = "0x9FD4", Offset = "0x9FD4", VA = "0x9FD4", Slot = "22")]
		protected override void OnShow(AttackMonsterWindowArgs args)
		{
		}

		// Token: 0x060051FE RID: 20990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051FE")]
		[Address(RVA = "0x9FD5", Offset = "0x9FD5", VA = "0x9FD5")]
		private void CloseAreaEventHandler()
		{
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051FF")]
		[Address(RVA = "0x9FD6", Offset = "0x9FD6", VA = "0x9FD6", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06005200 RID: 20992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005200")]
		[Address(RVA = "0x9FD7", Offset = "0x9FD7", VA = "0x9FD7")]
		public IsleMonsterInfoWindow2()
		{
		}

		// Token: 0x04002C91 RID: 11409
		[Token(Token = "0x4002C91")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/IsleMonster/IsleMonsterInfoWindow2";

		// Token: 0x04002C92 RID: 11410
		[Token(Token = "0x4002C92")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MonsterInfoView2 _monsterInfoView;

		// Token: 0x04002C93 RID: 11411
		[Token(Token = "0x4002C93")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private WikiUriRouter _wiki;

		// Token: 0x04002C94 RID: 11412
		[Token(Token = "0x4002C94")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _closeArea;

		// Token: 0x04002C95 RID: 11413
		[Token(Token = "0x4002C95")]
		[FieldOffset(Offset = "0x44")]
		private IsleMonsterInfoWindowMediator2 _mediator;
	}
}
