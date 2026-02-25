using System;
using AssetContent;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using TMPro;
using UI.ToolTip.Implementations;
using UnityEngine;

namespace Gameplay.Portals.View.RatingTab
{
	// Token: 0x020005C5 RID: 1477
	[Token(Token = "0x20005C5")]
	public class UserInPortalRatingListElement : UserRatingListElement
	{
		// Token: 0x0600236F RID: 9071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236F")]
		[Address(RVA = "0x74C2", Offset = "0x74C2", VA = "0x74C2", Slot = "12")]
		protected virtual void Start()
		{
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002370")]
		[Address(RVA = "0x74C3", Offset = "0x74C3", VA = "0x74C3", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002371")]
		[Address(RVA = "0x74C4", Offset = "0x74C4", VA = "0x74C4")]
		public UserInPortalRatingListElement()
		{
		}

		// Token: 0x0400137B RID: 4987
		[Token(Token = "0x400137B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TextMeshProUGUI _participant;

		// Token: 0x0400137C RID: 4988
		[Token(Token = "0x400137C")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		protected GameImage _icon;

		// Token: 0x0400137D RID: 4989
		[Token(Token = "0x400137D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextToolTip _scoreToolTip;

		// Token: 0x0400137E RID: 4990
		[Token(Token = "0x400137E")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextToolTip _participantToolTip;

		// Token: 0x020005C6 RID: 1478
		[Token(Token = "0x20005C6")]
		public class UserInPortalRatingListElementArgs : UserInRatingListElement.UserInRatingListElementArgs
		{
			// Token: 0x06002372 RID: 9074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002372")]
			[Address(RVA = "0x74C5", Offset = "0x74C5", VA = "0x74C5")]
			public UserInPortalRatingListElementArgs()
			{
			}

			// Token: 0x0400137F RID: 4991
			[Token(Token = "0x400137F")]
			[FieldOffset(Offset = "0x30")]
			public uint Participant;

			// Token: 0x04001380 RID: 4992
			[Token(Token = "0x4001380")]
			[FieldOffset(Offset = "0x34")]
			public string IconAssetID;
		}
	}
}
