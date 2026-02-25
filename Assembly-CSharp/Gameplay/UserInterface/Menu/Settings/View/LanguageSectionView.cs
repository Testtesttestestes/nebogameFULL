using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gameplay.UserInterface.Menu.Settings.View
{
	// Token: 0x020003D9 RID: 985
	[Token(Token = "0x20003D9")]
	[DisallowMultipleComponent]
	public class LanguageSectionView : MonoBehaviour
	{
		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x00005598 File Offset: 0x00003798
		// (set) Token: 0x06001718 RID: 5912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003FA")]
		public SystemLanguage Language
		{
			[Token(Token = "0x6001719")]
			[Address(RVA = "0x68D8", Offset = "0x68D8", VA = "0x68D8")]
			get
			{
				return SystemLanguage.Afrikaans;
			}
			[Token(Token = "0x6001718")]
			[Address(RVA = "0x68D7", Offset = "0x68D7", VA = "0x68D7")]
			set
			{
			}
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600171A")]
		[Address(RVA = "0x68D9", Offset = "0x68D9", VA = "0x68D9")]
		public void OnToggle(bool selected)
		{
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600171B")]
		[Address(RVA = "0x68DA", Offset = "0x68DA", VA = "0x68DA")]
		public LanguageSectionView()
		{
		}

		// Token: 0x04000C47 RID: 3143
		[Token(Token = "0x4000C47")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Toggle _defaultToggle;

		// Token: 0x04000C48 RID: 3144
		[Token(Token = "0x4000C48")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Toggle _enToggle;

		// Token: 0x04000C49 RID: 3145
		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Toggle _ruToggle;

		// Token: 0x04000C4A RID: 3146
		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0x1C")]
		public LanguageSectionView.LanguageChangedEvent OnLanguageChanged;

		// Token: 0x04000C4B RID: 3147
		[Token(Token = "0x4000C4B")]
		[FieldOffset(Offset = "0x20")]
		private SystemLanguage _language;

		// Token: 0x020003DA RID: 986
		[Token(Token = "0x20003DA")]
		[Serializable]
		public class LanguageChangedEvent : UnityEvent<SystemLanguage>
		{
			// Token: 0x0600171C RID: 5916 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600171C")]
			[Address(RVA = "0x68DB", Offset = "0x68DB", VA = "0x68DB")]
			public LanguageChangedEvent()
			{
			}
		}
	}
}
