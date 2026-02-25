using System;
using System.Runtime.CompilerServices;
using Core;
using Core.Data;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using Protocol;
using Protocol.Dic;
using UI;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Inventory.View
{
	// Token: 0x02000657 RID: 1623
	[Token(Token = "0x2000657")]
	public class ArtifactView : AbstractDataRenderer<ArtifactData>, IArtifactView, IPointerEnterHandler, IEventSystemHandler, IToolTipDataProvider, IPointerClickHandler
	{
		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06002754 RID: 10068 RVA: 0x00007890 File Offset: 0x00005A90
		// (set) Token: 0x06002755 RID: 10069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700076B")]
		public InteractiveBehavior Mode
		{
			[Token(Token = "0x6002754")]
			[Address(RVA = "0x7887", Offset = "0x7887", VA = "0x7887")]
			get
			{
				return InteractiveBehavior.Default;
			}
			[Token(Token = "0x6002755")]
			[Address(RVA = "0x7888", Offset = "0x7888", VA = "0x7888")]
			set
			{
			}
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002756")]
		[Address(RVA = "0x7889", Offset = "0x7889", VA = "0x7889", Slot = "9")]
		protected override void Awake()
		{
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002757")]
		[Address(RVA = "0x788A", Offset = "0x788A", VA = "0x788A", Slot = "10")]
		public override void Dispose()
		{
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002758")]
		[Address(RVA = "0x788B", Offset = "0x788B", VA = "0x788B", Slot = "17")]
		protected override void StartListenEvents(ArtifactData data)
		{
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002759")]
		[Address(RVA = "0x788C", Offset = "0x788C", VA = "0x788C")]
		private void ArtifactDataOnSlotIdChangedEvent()
		{
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600275A")]
		[Address(RVA = "0x788D", Offset = "0x788D", VA = "0x788D", Slot = "18")]
		protected override void StopListenEvents(ArtifactData data)
		{
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600275B RID: 10075 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700076C")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x600275B")]
			[Address(RVA = "0x788E", Offset = "0x788E", VA = "0x788E")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000151 RID: 337
		// (add) Token: 0x0600275C RID: 10076 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600275D RID: 10077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000151")]
		public event Action<ArtifactView> ClickEvent
		{
			[Token(Token = "0x600275C")]
			[Address(RVA = "0x1D8E", Offset = "0x1D8E", VA = "0x1D8E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600275D")]
			[Address(RVA = "0x788F", Offset = "0x788F", VA = "0x788F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600275E")]
		[Address(RVA = "0x7890", Offset = "0x7890", VA = "0x7890", Slot = "16")]
		protected override void OnDataInvalidated()
		{
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x000078A8 File Offset: 0x00005AA8
		// (set) Token: 0x06002760 RID: 10080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700076D")]
		public ArtifactView.ArtifactViewArgs Args
		{
			[Token(Token = "0x600275F")]
			[Address(RVA = "0x7891", Offset = "0x7891", VA = "0x7891", Slot = "23")]
			get
			{
				return default(ArtifactView.ArtifactViewArgs);
			}
			[Token(Token = "0x6002760")]
			[Address(RVA = "0x1D8D", Offset = "0x1D8D", VA = "0x1D8D", Slot = "24")]
			set
			{
			}
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002761")]
		[Address(RVA = "0x7892", Offset = "0x7892", VA = "0x7892")]
		private void ArtifactDataOnIsMostPowerfulChangedEvent()
		{
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002762")]
		[Address(RVA = "0x7893", Offset = "0x7893", VA = "0x7893")]
		private void ArtifactDataOnArtifactInfoChangedEvent()
		{
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002763")]
		[Address(RVA = "0x7894", Offset = "0x7894", VA = "0x7894")]
		private void ArtifactDataOnIsFreshWatchedChangedEvent()
		{
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002764")]
		[Address(RVA = "0x7895", Offset = "0x7895", VA = "0x7895")]
		private void ArtifactDataOnIsFreshChangedEvent()
		{
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002765")]
		[Address(RVA = "0x7896", Offset = "0x7896", VA = "0x7896")]
		private void ArtifactDataOnIsFavoriteChangedEvent()
		{
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002766")]
		[Address(RVA = "0x7897", Offset = "0x7897", VA = "0x7897", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002767")]
		[Address(RVA = "0x7898", Offset = "0x7898", VA = "0x7898", Slot = "5")]
		protected override void CommitProperties()
		{
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002768")]
		[Address(RVA = "0x7899", Offset = "0x7899", VA = "0x7899")]
		private void RenderIsEquippedIcon()
		{
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002769")]
		[Address(RVA = "0x789A", Offset = "0x789A", VA = "0x789A")]
		private void RenderFavoriteIcon()
		{
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276A")]
		[Address(RVA = "0x789B", Offset = "0x789B", VA = "0x789B")]
		private void RenderFreshIcon()
		{
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276B")]
		[Address(RVA = "0x789C", Offset = "0x789C", VA = "0x789C")]
		private void RenderBestIcon()
		{
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276C")]
		[Address(RVA = "0x789D", Offset = "0x789D", VA = "0x789D")]
		private void RenderStackSize()
		{
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276D")]
		[Address(RVA = "0x789E", Offset = "0x789E", VA = "0x789E", Slot = "32")]
		protected virtual void UpdateStatusView()
		{
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276E")]
		[Address(RVA = "0x789F", Offset = "0x789F", VA = "0x789F")]
		private void ShowContextMenu()
		{
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276F")]
		[Address(RVA = "0x78A0", Offset = "0x78A0", VA = "0x78A0", Slot = "31")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002770")]
		[Address(RVA = "0x78A1", Offset = "0x78A1", VA = "0x78A1", Slot = "29")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002771")]
		[Address(RVA = "0x78A2", Offset = "0x78A2", VA = "0x78A2", Slot = "30")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06002772 RID: 10098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700076E")]
		public GameObject GameObject
		{
			[Token(Token = "0x6002772")]
			[Address(RVA = "0x78A3", Offset = "0x78A3", VA = "0x78A3", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700076F")]
		public IActionInfo Info
		{
			[Token(Token = "0x6002773")]
			[Address(RVA = "0x78A4", Offset = "0x78A4", VA = "0x78A4", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06002774 RID: 10100 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000770")]
		public BackTime Backtime
		{
			[Token(Token = "0x6002774")]
			[Address(RVA = "0x78A5", Offset = "0x78A5", VA = "0x78A5", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x000078C0 File Offset: 0x00005AC0
		[Token(Token = "0x17000771")]
		public bool OnlyMarketAccount
		{
			[Token(Token = "0x6002775")]
			[Address(RVA = "0x78A6", Offset = "0x78A6", VA = "0x78A6", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06002776 RID: 10102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000772")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x6002776")]
			[Address(RVA = "0x78A7", Offset = "0x78A7", VA = "0x78A7", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002777")]
		[Address(RVA = "0x78A8", Offset = "0x78A8", VA = "0x78A8")]
		public ArtifactView()
		{
		}

		// Token: 0x0400158B RID: 5515
		[Token(Token = "0x400158B")]
		[FieldOffset(Offset = "0x24")]
		private InteractiveBehavior _mode;

		// Token: 0x0400158C RID: 5516
		[Token(Token = "0x400158C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x0400158D RID: 5517
		[Token(Token = "0x400158D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Image _favIcon;

		// Token: 0x0400158E RID: 5518
		[Token(Token = "0x400158E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _freshIcon;

		// Token: 0x0400158F RID: 5519
		[Token(Token = "0x400158F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Image _bestIcon;

		// Token: 0x04001590 RID: 5520
		[Token(Token = "0x4001590")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _isEquippedIcon;

		// Token: 0x04001591 RID: 5521
		[Token(Token = "0x4001591")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ArtifactStatusDisplay _statusDisplay;

		// Token: 0x04001592 RID: 5522
		[Token(Token = "0x4001592")]
		[FieldOffset(Offset = "0x40")]
		private bool _isBestChanged;

		// Token: 0x04001593 RID: 5523
		[Token(Token = "0x4001593")]
		[FieldOffset(Offset = "0x41")]
		private bool _stackSizeChanged;

		// Token: 0x04001594 RID: 5524
		[Token(Token = "0x4001594")]
		[FieldOffset(Offset = "0x42")]
		private bool _isFavoriteChanged;

		// Token: 0x04001595 RID: 5525
		[Token(Token = "0x4001595")]
		[FieldOffset(Offset = "0x43")]
		private bool _isFreshChanged;

		// Token: 0x04001596 RID: 5526
		[Token(Token = "0x4001596")]
		[FieldOffset(Offset = "0x44")]
		private bool _statusChanged;

		// Token: 0x04001597 RID: 5527
		[Token(Token = "0x4001597")]
		[FieldOffset(Offset = "0x45")]
		private bool _isEquippedChanged;

		// Token: 0x04001598 RID: 5528
		[Token(Token = "0x4001598")]
		[FieldOffset(Offset = "0x48")]
		private IGuideTarget _guideTarget;

		// Token: 0x0400159A RID: 5530
		[Token(Token = "0x400159A")]
		[FieldOffset(Offset = "0x50")]
		private ArtifactView.ArtifactViewArgs _args;

		// Token: 0x02000658 RID: 1624
		[Token(Token = "0x2000658")]
		public struct ArtifactViewArgs
		{
			// Token: 0x0400159E RID: 5534
			[Token(Token = "0x400159E")]
			[FieldOffset(Offset = "0x0")]
			public InteractiveBehavior Mode;

			// Token: 0x0400159F RID: 5535
			[Token(Token = "0x400159F")]
			[FieldOffset(Offset = "0x4")]
			public ArtikulMenuActionDic.Types.Actions[] CustomActions;

			// Token: 0x040015A0 RID: 5536
			[Token(Token = "0x40015A0")]
			[FieldOffset(Offset = "0x8")]
			public ArtifactView.ArtifactViewArgs.ArtifactViewOptions ViewOptions;

			// Token: 0x02000659 RID: 1625
			[Token(Token = "0x2000659")]
			[Flags]
			public enum ArtifactViewOptions
			{
				// Token: 0x040015A2 RID: 5538
				[Token(Token = "0x40015A2")]
				None = 0,
				// Token: 0x040015A3 RID: 5539
				[Token(Token = "0x40015A3")]
				EnableIsEquippedIcon = 1
			}
		}
	}
}
