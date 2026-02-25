using System;
using Gameplay.Aprs.View;
using Gameplay.Horde.Model.Data;
using Il2CppDummyDll;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.Horde.View
{
	// Token: 0x020006FB RID: 1787
	[Token(Token = "0x20006FB")]
	public class HordeMonsterAprView : GenericListElement<HordeMonsterAprView.HordeMonsterAprViewArgs>
	{
		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700081A")]
		public HordeMonsterData Data
		{
			[Token(Token = "0x6002ABD")]
			[Address(RVA = "0x7B58", Offset = "0x7B58", VA = "0x7B58")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (set) Token: 0x06002ABE RID: 10942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081B")]
		public bool Selected
		{
			[Token(Token = "0x6002ABE")]
			[Address(RVA = "0x7B59", Offset = "0x7B59", VA = "0x7B59")]
			set
			{
			}
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ABF")]
		[Address(RVA = "0x7B5A", Offset = "0x7B5A", VA = "0x7B5A")]
		private void Awake()
		{
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC0")]
		[Address(RVA = "0x7B5B", Offset = "0x7B5B", VA = "0x7B5B")]
		private void ClickEventHandler(HordeMonsterAprView.HordeMonsterAprViewArgs args)
		{
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC1")]
		[Address(RVA = "0x7B5C", Offset = "0x7B5C", VA = "0x7B5C", Slot = "4")]
		protected override void OnInit(HordeMonsterAprView.HordeMonsterAprViewArgs args)
		{
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AC2")]
		[Address(RVA = "0x7B5D", Offset = "0x7B5D", VA = "0x7B5D")]
		public HordeMonsterAprView()
		{
		}

		// Token: 0x04001756 RID: 5974
		[Token(Token = "0x4001756")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AprViewSmall _aprView;

		// Token: 0x04001757 RID: 5975
		[Token(Token = "0x4001757")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _defeatedImage;

		// Token: 0x04001758 RID: 5976
		[Token(Token = "0x4001758")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectedImage;

		// Token: 0x020006FC RID: 1788
		[Token(Token = "0x20006FC")]
		public class HordeMonsterAprViewArgs : GenericListElementArgs
		{
			// Token: 0x06002AC3 RID: 10947 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002AC3")]
			[Address(RVA = "0x7B5E", Offset = "0x7B5E", VA = "0x7B5E")]
			public HordeMonsterAprViewArgs()
			{
			}

			// Token: 0x04001759 RID: 5977
			[Token(Token = "0x4001759")]
			[FieldOffset(Offset = "0xC")]
			public HordeMonsterData Data;

			// Token: 0x0400175A RID: 5978
			[Token(Token = "0x400175A")]
			[FieldOffset(Offset = "0x10")]
			public bool Defeated;

			// Token: 0x0400175B RID: 5979
			[Token(Token = "0x400175B")]
			[FieldOffset(Offset = "0x14")]
			public Action<HordeMonsterAprView> SelectedCallback;
		}
	}
}
