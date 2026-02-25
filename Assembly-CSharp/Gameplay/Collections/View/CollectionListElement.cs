using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.GenericList;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Collections.View
{
	// Token: 0x020009C3 RID: 2499
	[Token(Token = "0x20009C3")]
	public class CollectionListElement : GenericListElement<CollectionListElement.CollectionListElementArgs>, IToolTipDataProvider
	{
		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06003BDD RID: 15325 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BD3")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6003BDD")]
			[Address(RVA = "0x8AB1", Offset = "0x8AB1", VA = "0x8AB1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (set) Token: 0x06003BDE RID: 15326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD4")]
		private CollectionListElement.CollectionListElementArgs Args
		{
			[Token(Token = "0x6003BDE")]
			[Address(RVA = "0x8AB2", Offset = "0x8AB2", VA = "0x8AB2")]
			set
			{
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06003BDF RID: 15327 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003BE0 RID: 15328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD5")]
		public CollectionListElement.CollectionListElementArgs Data
		{
			[Token(Token = "0x6003BDF")]
			[Address(RVA = "0x8AB3", Offset = "0x8AB3", VA = "0x8AB3")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BE0")]
			[Address(RVA = "0x8AB4", Offset = "0x8AB4", VA = "0x8AB4")]
			set
			{
			}
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE1")]
		[Address(RVA = "0x8AB5", Offset = "0x8AB5", VA = "0x8AB5")]
		private void Awake()
		{
		}

		// Token: 0x06003BE2 RID: 15330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE2")]
		[Address(RVA = "0x8AB6", Offset = "0x8AB6", VA = "0x8AB6")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003BE3 RID: 15331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE3")]
		[Address(RVA = "0x8AB7", Offset = "0x8AB7", VA = "0x8AB7")]
		private void DataChangedEventHandler()
		{
		}

		// Token: 0x06003BE4 RID: 15332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE4")]
		[Address(RVA = "0x8AB8", Offset = "0x8AB8", VA = "0x8AB8")]
		private void OnClickEventHandler(CollectionListElement.CollectionListElementArgs args)
		{
		}

		// Token: 0x06003BE5 RID: 15333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE5")]
		[Address(RVA = "0x8AB9", Offset = "0x8AB9", VA = "0x8AB9")]
		private void UpgradeButtonClicked()
		{
		}

		// Token: 0x06003BE6 RID: 15334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE6")]
		[Address(RVA = "0x8ABA", Offset = "0x8ABA", VA = "0x8ABA", Slot = "4")]
		protected override void OnInit(CollectionListElement.CollectionListElementArgs args)
		{
		}

		// Token: 0x06003BE7 RID: 15335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE7")]
		[Address(RVA = "0x8ABB", Offset = "0x8ABB", VA = "0x8ABB")]
		private void ApplyArgs()
		{
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE8")]
		[Address(RVA = "0x8ABC", Offset = "0x8ABC", VA = "0x8ABC")]
		private void UpdateProgress()
		{
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BE9")]
		[Address(RVA = "0x8ABD", Offset = "0x8ABD", VA = "0x8ABD")]
		private void SetActiveObjects(CollectionData data)
		{
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003BEA")]
		[Address(RVA = "0x8ABE", Offset = "0x8ABE", VA = "0x8ABE", Slot = "7")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BEB")]
		[Address(RVA = "0x8ABF", Offset = "0x8ABF", VA = "0x8ABF")]
		public CollectionListElement()
		{
		}

		// Token: 0x04002108 RID: 8456
		[Token(Token = "0x4002108")]
		private const int DECIMAL_TO_PERCENTAGE = 100;

		// Token: 0x04002109 RID: 8457
		[Token(Token = "0x4002109")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CollectionView _view;

		// Token: 0x0400210A RID: 8458
		[Token(Token = "0x400210A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _maxLevelText;

		// Token: 0x0400210B RID: 8459
		[Token(Token = "0x400210B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _upgradeButton;

		// Token: 0x0400210C RID: 8460
		[Token(Token = "0x400210C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Image _progressBar;

		// Token: 0x0400210D RID: 8461
		[Token(Token = "0x400210D")]
		[FieldOffset(Offset = "0x30")]
		private IGuideTarget _guideTarget;

		// Token: 0x020009C4 RID: 2500
		[Token(Token = "0x20009C4")]
		public class CollectionListElementArgs : GenericListElementArgs
		{
			// Token: 0x14000190 RID: 400
			// (add) Token: 0x06003BEC RID: 15340 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06003BED RID: 15341 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x14000190")]
			public event Action DataChangedEvent
			{
				[Token(Token = "0x6003BEC")]
				[Address(RVA = "0x8AC0", Offset = "0x8AC0", VA = "0x8AC0")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6003BED")]
				[Address(RVA = "0x8AC1", Offset = "0x8AC1", VA = "0x8AC1")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x06003BEE RID: 15342 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003BEE")]
			[Address(RVA = "0x8AC2", Offset = "0x8AC2", VA = "0x8AC2")]
			public void CallDataChangedEvent()
			{
			}

			// Token: 0x06003BEF RID: 15343 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003BEF")]
			[Address(RVA = "0x8AC3", Offset = "0x8AC3", VA = "0x8AC3")]
			public CollectionListElementArgs()
			{
			}

			// Token: 0x0400210E RID: 8462
			[Token(Token = "0x400210E")]
			[FieldOffset(Offset = "0xC")]
			public CollectionData CollectionData;

			// Token: 0x0400210F RID: 8463
			[Token(Token = "0x400210F")]
			[FieldOffset(Offset = "0x10")]
			public Action<CollectionListElement.CollectionListElementArgs> ClickEventHandler;

			// Token: 0x04002110 RID: 8464
			[Token(Token = "0x4002110")]
			[FieldOffset(Offset = "0x14")]
			public bool SameUser;

			// Token: 0x04002111 RID: 8465
			[Token(Token = "0x4002111")]
			[FieldOffset(Offset = "0x18")]
			public UserData Owner;

			// Token: 0x04002112 RID: 8466
			[Token(Token = "0x4002112")]
			[FieldOffset(Offset = "0x1C")]
			public float Progress;
		}
	}
}
