using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInfo.View.Equipment
{
	// Token: 0x0200040C RID: 1036
	[Token(Token = "0x200040C")]
	public abstract class BaseEquipmentView<T> : MonoBehaviour where T : IEquipmentSlotConfig
	{
		// Token: 0x14000119 RID: 281
		// (add) Token: 0x06001853 RID: 6227 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001854 RID: 6228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000119")]
		public event Action<T> SlotClickedEvent
		{
			[Token(Token = "0x6001853")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001854")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001855")]
		public T[] GetSlots()
		{
			return null;
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001857 RID: 6231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044D")]
		public Dictionary<int, ArtifactData> Artifacts
		{
			[Token(Token = "0x6001856")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001857")]
			set
			{
			}
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001858")]
		public void SetArgs(ArtifactView.ArtifactViewArgs value)
		{
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00005688 File Offset: 0x00003888
		[Token(Token = "0x6001859")]
		private bool TryGetSlotConfig(int slotId, out T result)
		{
			return default(bool);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600185A")]
		private void HandleArtifactsChanged()
		{
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600185B")]
		private void Awake()
		{
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600185C")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600185D")]
		private void SlotOnClickEvent(EquipmentSlotView slot)
		{
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600185E")]
		protected BaseEquipmentView()
		{
		}

		// Token: 0x04000D03 RID: 3331
		[Token(Token = "0x4000D03")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T[] _equipment;

		// Token: 0x04000D05 RID: 3333
		[Token(Token = "0x4000D05")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<int, ArtifactData> _artifacts;

		// Token: 0x04000D06 RID: 3334
		[Token(Token = "0x4000D06")]
		[FieldOffset(Offset = "0x0")]
		private int _artifactsCountChangedCount;

		// Token: 0x04000D07 RID: 3335
		[Token(Token = "0x4000D07")]
		[FieldOffset(Offset = "0x0")]
		private int _slotsGetCount;
	}
}
