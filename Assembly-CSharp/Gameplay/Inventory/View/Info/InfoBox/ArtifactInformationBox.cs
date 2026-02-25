using System;
using Core.Data.InfoRows;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;
using UI.Requirements;
using UnityEngine;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x0200066F RID: 1647
	[Token(Token = "0x200066F")]
	public class ArtifactInformationBox : MonoBehaviour
	{
		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060027F5 RID: 10229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000793")]
		public IItemInformationProvider Data
		{
			[Token(Token = "0x60027F4")]
			[Address(RVA = "0x791A", Offset = "0x791A", VA = "0x791A")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027F5")]
			[Address(RVA = "0x791B", Offset = "0x791B", VA = "0x791B")]
			set
			{
			}
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60027F6")]
		[Address(RVA = "0x2147", Offset = "0x2147", VA = "0x2147")]
		private ArtifactInformationBox.RowPrefabConfig GetRowPrefab(InformationRowTypes type)
		{
			return null;
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F7")]
		[Address(RVA = "0x791C", Offset = "0x791C", VA = "0x791C")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F8")]
		[Address(RVA = "0x791D", Offset = "0x791D", VA = "0x791D")]
		public void ResetInfo()
		{
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F9")]
		[Address(RVA = "0x791E", Offset = "0x791E", VA = "0x791E")]
		public ArtifactInformationBox()
		{
		}

		// Token: 0x040015F7 RID: 5623
		[Token(Token = "0x40015F7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected ArtifactInformationBox.RowPrefabConfig[] _prefabsByTypes;

		// Token: 0x040015F8 RID: 5624
		[Token(Token = "0x40015F8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected GameObject _separatorPrefab;

		// Token: 0x040015F9 RID: 5625
		[Token(Token = "0x40015F9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected RequirementsView _requirementsView;

		// Token: 0x040015FA RID: 5626
		[Token(Token = "0x40015FA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected GameObject _requirementsViewSeparator;

		// Token: 0x040015FB RID: 5627
		[Token(Token = "0x40015FB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected RequirementsView _targetRequirementsView;

		// Token: 0x040015FC RID: 5628
		[Token(Token = "0x40015FC")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameObject _targetRequirementsViewSeparator;

		// Token: 0x040015FD RID: 5629
		[Token(Token = "0x40015FD")]
		[FieldOffset(Offset = "0x28")]
		private IItemInformationProvider _data;

		// Token: 0x02000670 RID: 1648
		[Token(Token = "0x2000670")]
		[Serializable]
		public class RowPrefabConfig
		{
			// Token: 0x060027FA RID: 10234 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60027FA")]
			[Address(RVA = "0x791F", Offset = "0x791F", VA = "0x791F")]
			public RowPrefabConfig()
			{
			}

			// Token: 0x040015FE RID: 5630
			[Token(Token = "0x40015FE")]
			[FieldOffset(Offset = "0x8")]
			public InformationRowTypes Type;

			// Token: 0x040015FF RID: 5631
			[Token(Token = "0x40015FF")]
			[FieldOffset(Offset = "0xC")]
			public TitleRowView Prefab;
		}
	}
}
