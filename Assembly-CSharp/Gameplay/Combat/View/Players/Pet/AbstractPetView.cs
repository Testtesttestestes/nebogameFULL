using System;
using System.Runtime.CompilerServices;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Combat.View.Players.Pet
{
	// Token: 0x02000954 RID: 2388
	[Token(Token = "0x2000954")]
	public abstract class AbstractPetView : MonoBehaviour, IPetView
	{
		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06003896 RID: 14486 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003897 RID: 14487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B27")]
		public UserSkillDic CurrentHealUserSkillDic
		{
			[Token(Token = "0x6003896")]
			[Address(RVA = "0x8840", Offset = "0x8840", VA = "0x8840", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003897")]
			[Address(RVA = "0x8841", Offset = "0x8841", VA = "0x8841", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06003898 RID: 14488 RVA: 0x0000B448 File Offset: 0x00009648
		// (set) Token: 0x06003899 RID: 14489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B28")]
		public bool Visible
		{
			[Token(Token = "0x6003898")]
			[Address(RVA = "0x8842", Offset = "0x8842", VA = "0x8842", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003899")]
			[Address(RVA = "0x8843", Offset = "0x8843", VA = "0x8843", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x0600389A RID: 14490 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600389B RID: 14491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B29")]
		public PetData Data
		{
			[Token(Token = "0x600389A")]
			[Address(RVA = "0x8844", Offset = "0x8844", VA = "0x8844", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600389B")]
			[Address(RVA = "0x8845", Offset = "0x8845", VA = "0x8845", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x0600389C RID: 14492 RVA: 0x0000B460 File Offset: 0x00009660
		// (set) Token: 0x0600389D RID: 14493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B2A")]
		public bool IsDead
		{
			[Token(Token = "0x600389C")]
			[Address(RVA = "0x8846", Offset = "0x8846", VA = "0x8846", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600389D")]
			[Address(RVA = "0x8847", Offset = "0x8847", VA = "0x8847")]
			protected set
			{
			}
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600389E")]
		[Address(RVA = "0x8848", Offset = "0x8848", VA = "0x8848", Slot = "11")]
		public void UpdateHealth(float delay)
		{
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600389F")]
		[Address(RVA = "0x8849", Offset = "0x8849", VA = "0x8849")]
		protected void OnDisable()
		{
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038A0")]
		[Address(RVA = "0x884A", Offset = "0x884A", VA = "0x884A")]
		protected void OnEnable()
		{
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038A1")]
		[Address(RVA = "0x884B", Offset = "0x884B", VA = "0x884B")]
		protected void OnDestroy()
		{
		}

		// Token: 0x060038A2 RID: 14498
		[Token(Token = "0x60038A2")]
		protected abstract void HandleDataChanged();

		// Token: 0x060038A3 RID: 14499
		[Token(Token = "0x60038A3")]
		protected abstract void HandleVisibleChanged();

		// Token: 0x060038A4 RID: 14500
		[Token(Token = "0x60038A4")]
		protected abstract void HandleIsDeadChanged();

		// Token: 0x060038A5 RID: 14501
		[Token(Token = "0x60038A5")]
		protected abstract void DisplayCurrentHealth(PetData petData, UserSkillDic userSkillDic);

		// Token: 0x060038A6 RID: 14502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038A6")]
		[Address(RVA = "0x884C", Offset = "0x884C", VA = "0x884C")]
		protected AbstractPetView()
		{
		}

		// Token: 0x04001F4B RID: 8011
		[Token(Token = "0x4001F4B")]
		[FieldOffset(Offset = "0x14")]
		private bool _visible;

		// Token: 0x04001F4C RID: 8012
		[Token(Token = "0x4001F4C")]
		[FieldOffset(Offset = "0x18")]
		private PetData _pet;

		// Token: 0x04001F4D RID: 8013
		[Token(Token = "0x4001F4D")]
		[FieldOffset(Offset = "0x1C")]
		protected bool _isDead;
	}
}
