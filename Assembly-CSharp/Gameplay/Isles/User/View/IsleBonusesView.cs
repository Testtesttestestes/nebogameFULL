using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CloudsFly;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D18 RID: 3352
	[Token(Token = "0x2000D18")]
	public class IsleBonusesView : BaseWorldObjectRenderer
	{
		// Token: 0x140001F4 RID: 500
		// (add) Token: 0x060051D8 RID: 20952 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060051D9 RID: 20953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F4")]
		public event Action<uint> BonusClickedEvent
		{
			[Token(Token = "0x60051D8")]
			[Address(RVA = "0x9FB2", Offset = "0x9FB2", VA = "0x9FB2")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60051D9")]
			[Address(RVA = "0x9FB3", Offset = "0x9FB3", VA = "0x9FB3")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x060051DA RID: 20954 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700108F")]
		private GameObjectPool<IsleBonusView> IsleBonusPool
		{
			[Token(Token = "0x60051DA")]
			[Address(RVA = "0x9FB4", Offset = "0x9FB4", VA = "0x9FB4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x060051DB RID: 20955 RVA: 0x0000EE80 File Offset: 0x0000D080
		// (set) Token: 0x060051DC RID: 20956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001090")]
		public bool Interabtable
		{
			[Token(Token = "0x60051DB")]
			[Address(RVA = "0x9FB5", Offset = "0x9FB5", VA = "0x9FB5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60051DC")]
			[Address(RVA = "0x9FB6", Offset = "0x9FB6", VA = "0x9FB6")]
			set
			{
			}
		}

		// Token: 0x060051DD RID: 20957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051DD")]
		[Address(RVA = "0x9FB7", Offset = "0x9FB7", VA = "0x9FB7")]
		private void ValidateInteractable()
		{
		}

		// Token: 0x060051DE RID: 20958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051DE")]
		[Address(RVA = "0x9FB8", Offset = "0x9FB8", VA = "0x9FB8")]
		private void ResetPoolObjectDelegate(IsleBonusView pooledObject)
		{
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051DF")]
		[Address(RVA = "0x9FB9", Offset = "0x9FB9", VA = "0x9FB9")]
		public void RemoveBonus(IsleBonusView bonus)
		{
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E0")]
		[Address(RVA = "0x1E10", Offset = "0x1E10", VA = "0x1E10")]
		public void AddBonus(uint positionId, uint type, TreeBonusAnimation treeBonusAnimation, Vector2 positionFromServer)
		{
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E1")]
		[Address(RVA = "0x9FBA", Offset = "0x9FBA", VA = "0x9FBA")]
		private void SpriteLoaderOnClickEvent(IsleBonusView view)
		{
		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E2")]
		[Address(RVA = "0x9FBB", Offset = "0x9FBB", VA = "0x9FBB")]
		private void OnDestroy()
		{
		}

		// Token: 0x060051E3 RID: 20963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E3")]
		[Address(RVA = "0x9FBC", Offset = "0x9FBC", VA = "0x9FBC", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		}

		// Token: 0x060051E4 RID: 20964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E4")]
		[Address(RVA = "0x9FBD", Offset = "0x9FBD", VA = "0x9FBD", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		}

		// Token: 0x060051E5 RID: 20965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E5")]
		[Address(RVA = "0x9FBE", Offset = "0x9FBE", VA = "0x9FBE")]
		public void ShowBonusCollected(uint positionId)
		{
		}

		// Token: 0x060051E6 RID: 20966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E6")]
		[Address(RVA = "0x9FBF", Offset = "0x9FBF", VA = "0x9FBF")]
		public void Clear()
		{
		}

		// Token: 0x060051E7 RID: 20967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E7")]
		[Address(RVA = "0x9FC0", Offset = "0x9FC0", VA = "0x9FC0")]
		public IsleBonusesView()
		{
		}

		// Token: 0x04002C7E RID: 11390
		[Token(Token = "0x4002C7E")]
		private const float BONUS_HIDE_DURATION = 0.2f;

		// Token: 0x04002C7F RID: 11391
		[Token(Token = "0x4002C7F")]
		private const float BONUS_HIDE_OFFSET = 20f;

		// Token: 0x04002C80 RID: 11392
		[Token(Token = "0x4002C80")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _bonusesContainer;

		// Token: 0x04002C81 RID: 11393
		[Token(Token = "0x4002C81")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private IsleBonusView _bonusPrefab;

		// Token: 0x04002C83 RID: 11395
		[Token(Token = "0x4002C83")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<uint, IsleBonusView> _views;

		// Token: 0x04002C84 RID: 11396
		[Token(Token = "0x4002C84")]
		[FieldOffset(Offset = "0x34")]
		private GameObjectPool<IsleBonusView> _isleBonusPool;

		// Token: 0x04002C85 RID: 11397
		[Token(Token = "0x4002C85")]
		[FieldOffset(Offset = "0x38")]
		private bool _interactable;
	}
}
