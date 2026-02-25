using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.ArtifactComparer.View
{
	// Token: 0x02000CDB RID: 3291
	[Token(Token = "0x2000CDB")]
	public class PossibleArtifactsGroupView : MonoBehaviour
	{
		// Token: 0x06005019 RID: 20505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005019")]
		[Address(RVA = "0x9E2D", Offset = "0x9E2D", VA = "0x9E2D")]
		protected void Awake()
		{
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600501A")]
		[Address(RVA = "0x9E2E", Offset = "0x9E2E", VA = "0x9E2E")]
		private void OnReleasePooledObject(ArtifactComparerPossibleArtifactView pooledObject)
		{
		}

		// Token: 0x140001E6 RID: 486
		// (add) Token: 0x0600501B RID: 20507 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600501C RID: 20508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001E6")]
		public event Action<ArtifactData> SelectArtifactEvent
		{
			[Token(Token = "0x600501B")]
			[Address(RVA = "0x9E2F", Offset = "0x9E2F", VA = "0x9E2F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600501C")]
			[Address(RVA = "0x9E30", Offset = "0x9E30", VA = "0x9E30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x0600501D RID: 20509 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600501E RID: 20510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001038")]
		public ArtikulTypeDic ArtikulTypeDic
		{
			[Token(Token = "0x600501D")]
			[Address(RVA = "0x9E31", Offset = "0x9E31", VA = "0x9E31")]
			get
			{
				return null;
			}
			[Token(Token = "0x600501E")]
			[Address(RVA = "0x9E32", Offset = "0x9E32", VA = "0x9E32")]
			set
			{
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x0600501F RID: 20511 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005020 RID: 20512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001039")]
		public List<ArtifactData> Artifacts
		{
			[Token(Token = "0x600501F")]
			[Address(RVA = "0x9E33", Offset = "0x9E33", VA = "0x9E33")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005020")]
			[Address(RVA = "0x9E34", Offset = "0x9E34", VA = "0x9E34")]
			set
			{
			}
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005021")]
		[Address(RVA = "0x1D92", Offset = "0x1D92", VA = "0x1D92")]
		private void HandleArtifactsChanged()
		{
		}

		// Token: 0x06005022 RID: 20514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005022")]
		[Address(RVA = "0x9E35", Offset = "0x9E35", VA = "0x9E35")]
		private void ViewOnClickEvent(ArtifactView artifactView)
		{
		}

		// Token: 0x06005023 RID: 20515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005023")]
		[Address(RVA = "0x1D94", Offset = "0x1D94", VA = "0x1D94")]
		public void SelectComparableArtifact(ArtifactData comparableArtifact)
		{
		}

		// Token: 0x06005024 RID: 20516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005024")]
		[Address(RVA = "0x9E36", Offset = "0x9E36", VA = "0x9E36")]
		private void HandleArtikulTypeDicChanged()
		{
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005025")]
		[Address(RVA = "0x9E37", Offset = "0x9E37", VA = "0x9E37")]
		public PossibleArtifactsGroupView()
		{
		}

		// Token: 0x04002BAE RID: 11182
		[Token(Token = "0x4002BAE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04002BAF RID: 11183
		[Token(Token = "0x4002BAF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002BB0 RID: 11184
		[Token(Token = "0x4002BB0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArtifactComparerPossibleArtifactView _artifactViewPrefab;

		// Token: 0x04002BB1 RID: 11185
		[Token(Token = "0x4002BB1")]
		[FieldOffset(Offset = "0x1C")]
		private GameObjectPool<ArtifactComparerPossibleArtifactView> _possibleArtifactsPool;

		// Token: 0x04002BB2 RID: 11186
		[Token(Token = "0x4002BB2")]
		[FieldOffset(Offset = "0x20")]
		private List<ArtifactComparerPossibleArtifactView> _currentPossibleArtifacts;

		// Token: 0x04002BB3 RID: 11187
		[Token(Token = "0x4002BB3")]
		[FieldOffset(Offset = "0x24")]
		private ArtikulTypeDic _artikulTypeDic;

		// Token: 0x04002BB5 RID: 11189
		[Token(Token = "0x4002BB5")]
		[FieldOffset(Offset = "0x2C")]
		private List<ArtifactData> _artifacts;
	}
}
