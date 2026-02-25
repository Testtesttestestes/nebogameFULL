using System;
using Gameplay.Horde.View;
using Gameplay.Isles.User.Controller;
using Il2CppDummyDll;
using UI.Wiki;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D1B RID: 3355
	[Token(Token = "0x2000D1B")]
	public class IsleMonsterInfoWindow : ClosableBaseWindow<AttackMonsterWindowArgs>
	{
		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x060051F0 RID: 20976 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001091")]
		public override string WindowId
		{
			[Token(Token = "0x60051F0")]
			[Address(RVA = "0x9FC7", Offset = "0x9FC7", VA = "0x9FC7", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x060051F1 RID: 20977 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001092")]
		public WikiUriRouter Wiki
		{
			[Token(Token = "0x60051F1")]
			[Address(RVA = "0x9FC8", Offset = "0x9FC8", VA = "0x9FC8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x060051F2 RID: 20978 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001093")]
		public MonsterInfoView MonsterInfoView
		{
			[Token(Token = "0x60051F2")]
			[Address(RVA = "0x9FC9", Offset = "0x9FC9", VA = "0x9FC9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x060051F3 RID: 20979 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001094")]
		public HordeView HordeView
		{
			[Token(Token = "0x60051F3")]
			[Address(RVA = "0x9FCA", Offset = "0x9FCA", VA = "0x9FCA")]
			get
			{
				return null;
			}
		}

		// Token: 0x060051F4 RID: 20980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051F4")]
		[Address(RVA = "0x9FCB", Offset = "0x9FCB", VA = "0x9FCB", Slot = "22")]
		protected override void OnShow(AttackMonsterWindowArgs args)
		{
		}

		// Token: 0x060051F5 RID: 20981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051F5")]
		[Address(RVA = "0x9FCC", Offset = "0x9FCC", VA = "0x9FCC", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060051F6 RID: 20982 RVA: 0x0000EE98 File Offset: 0x0000D098
		[Token(Token = "0x60051F6")]
		[Address(RVA = "0x9FCD", Offset = "0x9FCD", VA = "0x9FCD", Slot = "17")]
		public override bool CheckForClose()
		{
			return default(bool);
		}

		// Token: 0x060051F7 RID: 20983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051F7")]
		[Address(RVA = "0x9FCE", Offset = "0x9FCE", VA = "0x9FCE")]
		public IsleMonsterInfoWindow()
		{
		}

		// Token: 0x04002C8B RID: 11403
		[Token(Token = "0x4002C8B")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/IsleMonster/IsleMonsterInfoWindow";

		// Token: 0x04002C8C RID: 11404
		[Token(Token = "0x4002C8C")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MonsterInfoView _monsterInfoView;

		// Token: 0x04002C8D RID: 11405
		[Token(Token = "0x4002C8D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HordeView _hordeView;

		// Token: 0x04002C8E RID: 11406
		[Token(Token = "0x4002C8E")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private WikiUriRouter _wiki;

		// Token: 0x04002C8F RID: 11407
		[Token(Token = "0x4002C8F")]
		[FieldOffset(Offset = "0x48")]
		private IsleMonsterInfoWindowMediator _mediator;
	}
}
