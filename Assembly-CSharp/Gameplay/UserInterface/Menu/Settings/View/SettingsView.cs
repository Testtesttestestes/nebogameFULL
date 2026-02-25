using System;
using Gameplay.Sound.View;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInterface.Menu.Settings.View
{
	// Token: 0x020003DB RID: 987
	[Token(Token = "0x20003DB")]
	[DisallowMultipleComponent]
	public class SettingsView : MonoBehaviour
	{
		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003FB")]
		public AudioControlsView AudioControlsView
		{
			[Token(Token = "0x600171D")]
			[Address(RVA = "0x68DC", Offset = "0x68DC", VA = "0x68DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003FC")]
		public Toggle CombatAnimationsEnabled
		{
			[Token(Token = "0x600171E")]
			[Address(RVA = "0x68DD", Offset = "0x68DD", VA = "0x68DD")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003FD")]
		public Toggle CombatSpellAnimationsEnabled
		{
			[Token(Token = "0x600171F")]
			[Address(RVA = "0x68DE", Offset = "0x68DE", VA = "0x68DE")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003FE")]
		public Toggle WorldMovementAnimationsEnabled
		{
			[Token(Token = "0x6001720")]
			[Address(RVA = "0x68DF", Offset = "0x68DF", VA = "0x68DF")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003FF")]
		public LanguageSectionView LanguageSection
		{
			[Token(Token = "0x6001721")]
			[Address(RVA = "0x68E0", Offset = "0x68E0", VA = "0x68E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001722")]
		[Address(RVA = "0x68E1", Offset = "0x68E1", VA = "0x68E1")]
		public SettingsView()
		{
		}

		// Token: 0x04000C4C RID: 3148
		[Token(Token = "0x4000C4C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AudioControlsView audioControlsView;

		// Token: 0x04000C4D RID: 3149
		[Token(Token = "0x4000C4D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Toggle _combatAnimationsEnabled;

		// Token: 0x04000C4E RID: 3150
		[Token(Token = "0x4000C4E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Toggle _combatSpellAnimationsEnabled;

		// Token: 0x04000C4F RID: 3151
		[Token(Token = "0x4000C4F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Toggle _worldMovementAnimationsEnabled;

		// Token: 0x04000C50 RID: 3152
		[Token(Token = "0x4000C50")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LanguageSectionView _languageSection;
	}
}
