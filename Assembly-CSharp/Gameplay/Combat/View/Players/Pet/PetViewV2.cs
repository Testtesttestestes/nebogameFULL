using System;
using AssetContent.Loaders;
using Core.Animations;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Elements.ProgressBars;
using UnityEngine;

namespace Gameplay.Combat.View.Players.Pet
{
	// Token: 0x02000958 RID: 2392
	[Token(Token = "0x2000958")]
	public class PetViewV2 : AbstractPetView
	{
		// Token: 0x060038B7 RID: 14519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B7")]
		[Address(RVA = "0x8855", Offset = "0x8855", VA = "0x8855", Slot = "14")]
		protected override void HandleIsDeadChanged()
		{
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B8")]
		[Address(RVA = "0x8856", Offset = "0x8856", VA = "0x8856", Slot = "13")]
		protected override void HandleVisibleChanged()
		{
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B9")]
		[Address(RVA = "0x8857", Offset = "0x8857", VA = "0x8857", Slot = "12")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038BA")]
		[Address(RVA = "0x8858", Offset = "0x8858", VA = "0x8858", Slot = "15")]
		protected override void DisplayCurrentHealth(PetData petData, UserSkillDic userSkillDic)
		{
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038BB")]
		[Address(RVA = "0x8859", Offset = "0x8859", VA = "0x8859")]
		public PetViewV2()
		{
		}

		// Token: 0x04001F52 RID: 8018
		[Token(Token = "0x4001F52")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameSpriteRendererLoader _image;

		// Token: 0x04001F53 RID: 8019
		[Token(Token = "0x4001F53")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ProgressBarLiquidWithEdge _healBar;

		// Token: 0x04001F54 RID: 8020
		[Token(Token = "0x4001F54")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameSpineUiAnimation _deathAnimation;
	}
}
