using System;
using System.Collections.Generic;
using Gameplay.Combat.View.Animations;
using Gameplay.Combat.View.GameField;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.VFX
{
	// Token: 0x0200092C RID: 2348
	[Token(Token = "0x200092C")]
	public class StoneDestroyVFX : MonoBehaviour
	{
		// Token: 0x0600376D RID: 14189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600376D")]
		[Address(RVA = "0x875B", Offset = "0x875B", VA = "0x875B")]
		private void UpdateElements()
		{
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x0000B1D8 File Offset: 0x000093D8
		[Token(Token = "0x600376E")]
		[Address(RVA = "0x875C", Offset = "0x875C", VA = "0x875C")]
		public bool TryGetVFX(List<StoneMono> stones, bool isMyTurn, out CombatAnimation.IContent content)
		{
			return default(bool);
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600376F")]
		[Address(RVA = "0x875D", Offset = "0x875D", VA = "0x875D")]
		public void SetThemeSkin(Sprite skin, Sprite glow)
		{
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003770")]
		[Address(RVA = "0x19C7", Offset = "0x19C7", VA = "0x19C7")]
		private GameObjectPool<StoneDestroyElement> GetPool(StoneDestroyElement element)
		{
			return null;
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003771")]
		[Address(RVA = "0x875E", Offset = "0x875E", VA = "0x875E")]
		private void ResetPoolObjectDelegate(StoneDestroyElement pooledObject)
		{
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003772")]
		[Address(RVA = "0x875F", Offset = "0x875F", VA = "0x875F")]
		public StoneDestroyVFX()
		{
		}

		// Token: 0x04001E94 RID: 7828
		[Token(Token = "0x4001E94")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x04001E95 RID: 7829
		[Token(Token = "0x4001E95")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private List<StoneDestroyElement> _elements;

		// Token: 0x04001E96 RID: 7830
		[Token(Token = "0x4001E96")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<StonesTypes, GameObjectPool<StoneDestroyElement>> _pools;
	}
}
