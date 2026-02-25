using System;
using Gameplay.Isles.User;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows.Buildings
{
	// Token: 0x020002A3 RID: 675
	[Token(Token = "0x20002A3")]
	public abstract class BaseBuildingWindow<T> : BaseBuildingWindow<T, UserIsle> where T : BaseBuildingWindowArgs
	{
		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000241")]
		protected override BaseBuildingInfoView<UserIsle> BuildingInfoView
		{
			[Token(Token = "0x6000FF7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF8")]
		protected BaseBuildingWindow()
		{
		}

		// Token: 0x04000823 RID: 2083
		[Token(Token = "0x4000823")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private BuildingInfoView _buildingInfoView;
	}
}
