using System;
using AssetContent.Loaders;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;

namespace Gameplay.Combat.View.Players.Pet
{
	// Token: 0x02000957 RID: 2391
	[Token(Token = "0x2000957")]
	public class PetView : AbstractPetView
	{
		// Token: 0x060038B2 RID: 14514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B2")]
		[Address(RVA = "0x8850", Offset = "0x8850", VA = "0x8850", Slot = "14")]
		protected override void HandleIsDeadChanged()
		{
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B3")]
		[Address(RVA = "0x8851", Offset = "0x8851", VA = "0x8851", Slot = "13")]
		protected override void HandleVisibleChanged()
		{
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B4")]
		[Address(RVA = "0x8852", Offset = "0x8852", VA = "0x8852", Slot = "12")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B5")]
		[Address(RVA = "0x8853", Offset = "0x8853", VA = "0x8853", Slot = "15")]
		protected override void DisplayCurrentHealth(PetData petData, UserSkillDic userSkillDic)
		{
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B6")]
		[Address(RVA = "0x8854", Offset = "0x8854", VA = "0x8854")]
		public PetView()
		{
		}

		// Token: 0x04001F4F RID: 8015
		[Token(Token = "0x4001F4F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _nickField;

		// Token: 0x04001F50 RID: 8016
		[Token(Token = "0x4001F50")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameSpriteRendererLoader _image;

		// Token: 0x04001F51 RID: 8017
		[Token(Token = "0x4001F51")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CombatProgressBar _healBar;
	}
}
