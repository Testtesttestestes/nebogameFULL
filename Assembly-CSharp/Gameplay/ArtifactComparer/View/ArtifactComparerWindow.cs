using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.ArtifactComparer.Controller;
using Gameplay.ArtifactComparer.Model;
using Gameplay.ArtifactComparer.View.SkillSelector;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI;
using UI.Filters;
using UI.Windows;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.ArtifactComparer.View
{
	// Token: 0x02000CD9 RID: 3289
	[Token(Token = "0x2000CD9")]
	public class ArtifactComparerWindow : ClosableBaseWindow<ArtifactComparerWindow.ArtifactComparerWindowArgs>
	{
		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06004FFE RID: 20478 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700102E")]
		public override string WindowId
		{
			[Token(Token = "0x6004FFE")]
			[Address(RVA = "0x9E12", Offset = "0x9E12", VA = "0x9E12", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06004FFF RID: 20479 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700102F")]
		public ToggleButton SkillSelectorButton
		{
			[Token(Token = "0x6004FFF")]
			[Address(RVA = "0x9E13", Offset = "0x9E13", VA = "0x9E13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06005000 RID: 20480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001030")]
		public SkillSelectorView SkillSelectorView
		{
			[Token(Token = "0x6005000")]
			[Address(RVA = "0x9E14", Offset = "0x9E14", VA = "0x9E14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06005001 RID: 20481 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001031")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x6005001")]
			[Address(RVA = "0x9E15", Offset = "0x9E15", VA = "0x9E15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06005002 RID: 20482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001032")]
		public ArtifactComparerPowerBars PowerBars
		{
			[Token(Token = "0x6005002")]
			[Address(RVA = "0x9E16", Offset = "0x9E16", VA = "0x9E16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06005003 RID: 20483 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001033")]
		public TextMeshProUGUI SlotTitle
		{
			[Token(Token = "0x6005003")]
			[Address(RVA = "0x9E17", Offset = "0x9E17", VA = "0x9E17")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x06005004 RID: 20484 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001034")]
		public ArtifactComparerItemView LeftComparerView
		{
			[Token(Token = "0x6005004")]
			[Address(RVA = "0x9E18", Offset = "0x9E18", VA = "0x9E18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06005005 RID: 20485 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001035")]
		public ArtifactComparerItemView RightComparerView
		{
			[Token(Token = "0x6005005")]
			[Address(RVA = "0x9E19", Offset = "0x9E19", VA = "0x9E19")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06005006 RID: 20486 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001036")]
		public ArtifactComparerTable Table
		{
			[Token(Token = "0x6005006")]
			[Address(RVA = "0x9E1A", Offset = "0x9E1A", VA = "0x9E1A")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001E4 RID: 484
		// (add) Token: 0x06005007 RID: 20487 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005008 RID: 20488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001E4")]
		public event Action<ArtifactData> SelectArtifactEvent
		{
			[Token(Token = "0x6005007")]
			[Address(RVA = "0x9E1B", Offset = "0x9E1B", VA = "0x9E1B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005008")]
			[Address(RVA = "0x9E1C", Offset = "0x9E1C", VA = "0x9E1C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001E5 RID: 485
		// (add) Token: 0x06005009 RID: 20489 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600500A RID: 20490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001E5")]
		public event Action<ArtifactComparerWindow.ArtifactComparerWindowArgs> NewDataEvent
		{
			[Token(Token = "0x6005009")]
			[Address(RVA = "0x9E1D", Offset = "0x9E1D", VA = "0x9E1D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600500A")]
			[Address(RVA = "0x9E1E", Offset = "0x9E1E", VA = "0x9E1E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500B")]
		[Address(RVA = "0x9E1F", Offset = "0x9E1F", VA = "0x9E1F", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x0600500C RID: 20492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500C")]
		[Address(RVA = "0x9E20", Offset = "0x9E20", VA = "0x9E20")]
		private void OnReleasePooledObject(PossibleArtifactsGroupView pooledObject)
		{
		}

		// Token: 0x0600500D RID: 20493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500D")]
		[Address(RVA = "0x9E21", Offset = "0x9E21", VA = "0x9E21", Slot = "22")]
		protected override void OnShow(ArtifactComparerWindow.ArtifactComparerWindowArgs args)
		{
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500E")]
		[Address(RVA = "0x9E22", Offset = "0x9E22", VA = "0x9E22")]
		private void InitMvc()
		{
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500F")]
		[Address(RVA = "0x9E23", Offset = "0x9E23", VA = "0x9E23")]
		public void SetNewData(ArtifactComparerWindow.ArtifactComparerWindowArgs newArgs)
		{
		}

		// Token: 0x06005010 RID: 20496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005010")]
		[Address(RVA = "0x9E24", Offset = "0x9E24", VA = "0x9E24", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06005011 RID: 20497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005011")]
		[Address(RVA = "0x9E25", Offset = "0x9E25", VA = "0x9E25")]
		private void DestroyMvc()
		{
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06005012 RID: 20498 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005013 RID: 20499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001037")]
		public Dictionary<ArtikulTypeDic, List<ArtifactData>> PossibleArtifacts
		{
			[Token(Token = "0x6005012")]
			[Address(RVA = "0x9E26", Offset = "0x9E26", VA = "0x9E26")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005013")]
			[Address(RVA = "0x9E27", Offset = "0x9E27", VA = "0x9E27")]
			set
			{
			}
		}

		// Token: 0x06005014 RID: 20500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005014")]
		[Address(RVA = "0x9E28", Offset = "0x9E28", VA = "0x9E28")]
		private void HandlePossibleArtifactsChanged()
		{
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005015")]
		[Address(RVA = "0x9E29", Offset = "0x9E29", VA = "0x9E29")]
		private void ViewOnClickEvent(ArtifactData artifactData)
		{
		}

		// Token: 0x06005016 RID: 20502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005016")]
		[Address(RVA = "0x9E2A", Offset = "0x9E2A", VA = "0x9E2A")]
		public void SelectComparableArtifact(ArtifactData comparableArtifact)
		{
		}

		// Token: 0x06005017 RID: 20503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005017")]
		[Address(RVA = "0x9E2B", Offset = "0x9E2B", VA = "0x9E2B")]
		public ArtifactComparerWindow()
		{
		}

		// Token: 0x04002B95 RID: 11157
		[Token(Token = "0x4002B95")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/ArtifactComparerWindow";

		// Token: 0x04002B96 RID: 11158
		[Token(Token = "0x4002B96")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ArtifactComparerItemView _leftComparerView;

		// Token: 0x04002B97 RID: 11159
		[Token(Token = "0x4002B97")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ArtifactComparerItemView _rightComparerView;

		// Token: 0x04002B98 RID: 11160
		[Token(Token = "0x4002B98")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ArtifactComparerTable _table;

		// Token: 0x04002B99 RID: 11161
		[Token(Token = "0x4002B99")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArtifactComparerPowerBars _powerBars;

		// Token: 0x04002B9A RID: 11162
		[Token(Token = "0x4002B9A")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextMeshProUGUI _slotTitle;

		// Token: 0x04002B9B RID: 11163
		[Token(Token = "0x4002B9B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _possibleArtifactsContainer;

		// Token: 0x04002B9C RID: 11164
		[Token(Token = "0x4002B9C")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x04002B9D RID: 11165
		[Token(Token = "0x4002B9D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SkillSelectorView _skillSelectorView;

		// Token: 0x04002B9E RID: 11166
		[Token(Token = "0x4002B9E")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private ToggleButton _skillSelectorButton;

		// Token: 0x04002B9F RID: 11167
		[Token(Token = "0x4002B9F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private PossibleArtifactsGroupView _possibleArtifactsGroupViewPrefab;

		// Token: 0x04002BA0 RID: 11168
		[Token(Token = "0x4002BA0")]
		[FieldOffset(Offset = "0x64")]
		private GameObjectPool<PossibleArtifactsGroupView> _possibleArtifactsGroupPool;

		// Token: 0x04002BA1 RID: 11169
		[Token(Token = "0x4002BA1")]
		[FieldOffset(Offset = "0x68")]
		private List<PossibleArtifactsGroupView> _currentPossibleArtifactsroups;

		// Token: 0x04002BA2 RID: 11170
		[Token(Token = "0x4002BA2")]
		[FieldOffset(Offset = "0x6C")]
		private ArtifactComparerEvents _events;

		// Token: 0x04002BA3 RID: 11171
		[Token(Token = "0x4002BA3")]
		[FieldOffset(Offset = "0x70")]
		private ArtifactComparerModel _model;

		// Token: 0x04002BA4 RID: 11172
		[Token(Token = "0x4002BA4")]
		[FieldOffset(Offset = "0x74")]
		private ArtifactComparerController _controller;

		// Token: 0x04002BA5 RID: 11173
		[Token(Token = "0x4002BA5")]
		[FieldOffset(Offset = "0x78")]
		private ArtifactComparerWindowMediator _mediator;

		// Token: 0x04002BA8 RID: 11176
		[Token(Token = "0x4002BA8")]
		[FieldOffset(Offset = "0x84")]
		private Dictionary<ArtikulTypeDic, List<ArtifactData>> _possibleArtifacts;

		// Token: 0x02000CDA RID: 3290
		[Token(Token = "0x2000CDA")]
		public class ArtifactComparerWindowArgs : BaseWindowArgs
		{
			// Token: 0x06005018 RID: 20504 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005018")]
			[Address(RVA = "0x9E2C", Offset = "0x9E2C", VA = "0x9E2C")]
			public ArtifactComparerWindowArgs()
			{
			}

			// Token: 0x04002BA9 RID: 11177
			[Token(Token = "0x4002BA9")]
			[FieldOffset(Offset = "0x18")]
			public ArtifactData ArtifactData;

			// Token: 0x04002BAA RID: 11178
			[Token(Token = "0x4002BAA")]
			[FieldOffset(Offset = "0x1C")]
			public ArtifactComparerEvents Events;

			// Token: 0x04002BAB RID: 11179
			[Token(Token = "0x4002BAB")]
			[FieldOffset(Offset = "0x20")]
			public ArtifactComparerController Controller;

			// Token: 0x04002BAC RID: 11180
			[Token(Token = "0x4002BAC")]
			[FieldOffset(Offset = "0x24")]
			public ArtifactComparerModel Model;

			// Token: 0x04002BAD RID: 11181
			[Token(Token = "0x4002BAD")]
			[FieldOffset(Offset = "0x28")]
			public bool SameArticulTypeOnly;
		}
	}
}
