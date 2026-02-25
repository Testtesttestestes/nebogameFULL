using System;
using Gameplay.Isles.Clan;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows.Buildings
{
	// Token: 0x020002A4 RID: 676
	[Token(Token = "0x20002A4")]
	public abstract class BaseClanBuildingWindow<T> : BaseBuildingWindow<T, ClanIsle> where T : BaseClanBuildingWindowArgs
	{
		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000242")]
		protected override BaseBuildingInfoView<ClanIsle> BuildingInfoView
		{
			[Token(Token = "0x6000FF9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFA")]
		protected BaseClanBuildingWindow()
		{
		}

		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x4000824")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ClanBuildingInfoView _buildingInfoView;
	}
}
