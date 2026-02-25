using System;
using AssetContent;
using Core.Data;
using Gameplay.Isles.Clan;
using Il2CppDummyDll;
using UI.Windows.Buildings;
using UnityEngine;

namespace Gameplay.Clans.Buildings.Golem.View
{
	// Token: 0x02000AC7 RID: 2759
	[Token(Token = "0x2000AC7")]
	public class GolemWindow : BaseClanBuildingWindow<GolemWindow.GolemWindowArgs>
	{
		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06004286 RID: 17030 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D1A")]
		public override string WindowId
		{
			[Token(Token = "0x6004286")]
			[Address(RVA = "0x913A", Offset = "0x913A", VA = "0x913A", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004287")]
		[Address(RVA = "0x913B", Offset = "0x913B", VA = "0x913B", Slot = "22")]
		protected override void OnShow(GolemWindow.GolemWindowArgs args)
		{
		}

		// Token: 0x06004288 RID: 17032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004288")]
		[Address(RVA = "0x913C", Offset = "0x913C", VA = "0x913C")]
		public GolemWindow()
		{
		}

		// Token: 0x040024B2 RID: 9394
		[Token(Token = "0x40024B2")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Buildings/GolemWindow";

		// Token: 0x040024B3 RID: 9395
		[Token(Token = "0x40024B3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x02000AC8 RID: 2760
		[Token(Token = "0x2000AC8")]
		public class GolemWindowArgs : BaseClanBuildingWindowArgs
		{
			// Token: 0x06004289 RID: 17033 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004289")]
			[Address(RVA = "0x913D", Offset = "0x913D", VA = "0x913D")]
			public GolemWindowArgs(ClanIsle isle, uint buildingTypeId, UserData golemUserData)
			{
			}

			// Token: 0x040024B4 RID: 9396
			[Token(Token = "0x40024B4")]
			[FieldOffset(Offset = "0x20")]
			public UserData GolemUserData;
		}
	}
}
