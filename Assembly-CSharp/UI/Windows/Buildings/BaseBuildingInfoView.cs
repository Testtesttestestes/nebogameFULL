using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI.Elements.Counters;
using UnityEngine;

namespace UI.Windows.Buildings
{
	// Token: 0x020002A0 RID: 672
	[Token(Token = "0x20002A0")]
	public abstract class BaseBuildingInfoView<TIsle> : MonoBehaviour, IDisposable
	{
		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000236")]
		public TextMeshProUGUI TitleLabel
		{
			[Token(Token = "0x6000FBA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000237")]
		public TextMeshProUGUI DescLabel
		{
			[Token(Token = "0x6000FBB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000238")]
		public LevelCounter LevelCounter
		{
			[Token(Token = "0x6000FBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x140000FB RID: 251
		// (add) Token: 0x06000FBD RID: 4029 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000FBE RID: 4030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000FB")]
		public event Action RequestStartBuildEvent
		{
			[Token(Token = "0x6000FBD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000FBE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000FC RID: 252
		// (add) Token: 0x06000FBF RID: 4031 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000FC0 RID: 4032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000FC")]
		public event Action RequestAccelerateBuildEvent
		{
			[Token(Token = "0x6000FBF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000FC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000FD RID: 253
		// (add) Token: 0x06000FC1 RID: 4033 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000FC2 RID: 4034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000FD")]
		public event Action RequestCancelBuildEvent
		{
			[Token(Token = "0x6000FC1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000FC2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000FC3 RID: 4035
		[Token(Token = "0x17000239")]
		protected abstract UserData Owner { [Token(Token = "0x6000FC3")] get; }

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC4")]
		public void Init(TIsle isle, uint buildingTypeId)
		{
		}

		// Token: 0x06000FC5 RID: 4037
		[Token(Token = "0x6000FC5")]
		public abstract void OnInit(TIsle isle, uint buildingTypeId);

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FC6")]
		public BuildingInfoBuildView ShowDefaultState(BaseBuildingData userBuildingData, UserData user)
		{
			return null;
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FC7")]
		public BuildingInfoAccelerateView ShowBuildingState(BaseBuildingData userBuildingData, UserData loggedUser)
		{
			return null;
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC8")]
		public void ShowMaxLevelState()
		{
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC9")]
		private void ClearContent()
		{
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCA")]
		private void BuildClickHandler()
		{
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCB")]
		private void AccelerateClickHandler()
		{
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCC")]
		private void CancelClickHandler()
		{
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCD")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCE")]
		protected BaseBuildingInfoView()
		{
		}

		// Token: 0x040007FC RID: 2044
		[Token(Token = "0x40007FC")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TextMeshProUGUI _titleLabel;

		// Token: 0x040007FD RID: 2045
		[Token(Token = "0x40007FD")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TextMeshProUGUI _descLabel;

		// Token: 0x040007FE RID: 2046
		[Token(Token = "0x40007FE")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private LevelCounter _levelCounter;

		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x40007FF")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform _contentContainer;

		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private DiscountTargets[] _discountTargets;

		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000801")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private BuildingInfoBuildView _buildViewPrefab;

		// Token: 0x04000802 RID: 2050
		[Token(Token = "0x4000802")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private BuildingInfoAccelerateView _accelerateViewPrefab;

		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x4000803")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private GameObject _buildingInfoMaxLevelView;

		// Token: 0x04000807 RID: 2055
		[Token(Token = "0x4000807")]
		[FieldOffset(Offset = "0x0")]
		protected TIsle _isle;
	}
}
