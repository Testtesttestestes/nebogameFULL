using System;
using System.Collections.Generic;
using Gameplay.ArtifactComparer.Model;
using Gameplay.ArtifactComparer.View.Rows;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.ArtifactComparer.View
{
	// Token: 0x02000CD6 RID: 3286
	[Token(Token = "0x2000CD6")]
	public class ArtifactComparerTable : MonoBehaviour
	{
		// Token: 0x06004FF5 RID: 20469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF5")]
		[Address(RVA = "0x9E09", Offset = "0x9E09", VA = "0x9E09")]
		private void Awake()
		{
		}

		// Token: 0x06004FF6 RID: 20470 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004FF6")]
		[Address(RVA = "0x9E0A", Offset = "0x9E0A", VA = "0x9E0A")]
		private ArtifactComparerTable.ComparerRowPrefabConfig GetRowPrefab(ArtifactComparerRowData.RowType type)
		{
			return null;
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x06004FF7 RID: 20471 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004FF8 RID: 20472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700102D")]
		public IList<ArtifactComparerRowData> Data
		{
			[Token(Token = "0x6004FF7")]
			[Address(RVA = "0x9E0B", Offset = "0x9E0B", VA = "0x9E0B")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004FF8")]
			[Address(RVA = "0x9E0C", Offset = "0x9E0C", VA = "0x9E0C")]
			set
			{
			}
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FF9")]
		[Address(RVA = "0x9E0D", Offset = "0x9E0D", VA = "0x9E0D")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004FFA RID: 20474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FFA")]
		[Address(RVA = "0x9E0E", Offset = "0x9E0E", VA = "0x9E0E")]
		public ArtifactComparerTable()
		{
		}

		// Token: 0x04002B8E RID: 11150
		[Token(Token = "0x4002B8E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002B8F RID: 11151
		[Token(Token = "0x4002B8F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected ArtifactComparerTable.ComparerRowPrefabConfig[] _prefabsByTypes;

		// Token: 0x04002B90 RID: 11152
		[Token(Token = "0x4002B90")]
		[FieldOffset(Offset = "0x18")]
		private List<ArtifactComparerRowView> _currentRows;

		// Token: 0x04002B91 RID: 11153
		[Token(Token = "0x4002B91")]
		[FieldOffset(Offset = "0x1C")]
		private IList<ArtifactComparerRowData> _data;

		// Token: 0x02000CD7 RID: 3287
		[Token(Token = "0x2000CD7")]
		[Serializable]
		public class ComparerRowPrefabConfig
		{
			// Token: 0x06004FFB RID: 20475 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004FFB")]
			[Address(RVA = "0x9E0F", Offset = "0x9E0F", VA = "0x9E0F")]
			public ComparerRowPrefabConfig()
			{
			}

			// Token: 0x04002B92 RID: 11154
			[Token(Token = "0x4002B92")]
			[FieldOffset(Offset = "0x8")]
			public ArtifactComparerRowData.RowType Type;

			// Token: 0x04002B93 RID: 11155
			[Token(Token = "0x4002B93")]
			[FieldOffset(Offset = "0xC")]
			public ArtifactComparerRowView Prefab;
		}
	}
}
