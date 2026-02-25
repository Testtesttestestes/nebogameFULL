using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000DF5 RID: 3573
	[Token(Token = "0x2000DF5")]
	public class AccountLinkerView : MonoBehaviourWithStates<AccountLinkerView.States>
	{
		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x0600573D RID: 22333 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011C6")]
		public Button SetCodeBtnBtn
		{
			[Token(Token = "0x600573D")]
			[Address(RVA = "0xA4B8", Offset = "0xA4B8", VA = "0xA4B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x0600573E RID: 22334 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011C7")]
		public Button CodeGetButton
		{
			[Token(Token = "0x600573E")]
			[Address(RVA = "0xA4B9", Offset = "0xA4B9", VA = "0xA4B9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x0600573F RID: 22335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011C8")]
		public TextMeshProUGUI CodeGetDescription
		{
			[Token(Token = "0x600573F")]
			[Address(RVA = "0xA4BA", Offset = "0xA4BA", VA = "0xA4BA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06005740 RID: 22336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011C9")]
		public TMP_InputField CodeInputField
		{
			[Token(Token = "0x6005740")]
			[Address(RVA = "0xA4BB", Offset = "0xA4BB", VA = "0xA4BB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06005741 RID: 22337 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011CA")]
		public MonoPointerClickHandler HowGetCodeTextField
		{
			[Token(Token = "0x6005741")]
			[Address(RVA = "0xA4BC", Offset = "0xA4BC", VA = "0xA4BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06005742 RID: 22338 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011CB")]
		public SignInVariants SigninVariantsView
		{
			[Token(Token = "0x6005742")]
			[Address(RVA = "0xA4BD", Offset = "0xA4BD", VA = "0xA4BD")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005743 RID: 22339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005743")]
		[Address(RVA = "0xA4BE", Offset = "0xA4BE", VA = "0xA4BE")]
		public AccountLinkerView()
		{
		}

		// Token: 0x04002F3C RID: 12092
		[Token(Token = "0x4002F3C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _setCodeBtn;

		// Token: 0x04002F3D RID: 12093
		[Token(Token = "0x4002F3D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_InputField _codeInputField;

		// Token: 0x04002F3E RID: 12094
		[Token(Token = "0x4002F3E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private MonoPointerClickHandler _howGetCodeTextField;

		// Token: 0x04002F3F RID: 12095
		[Token(Token = "0x4002F3F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SignInVariants _signinVariantsView;

		// Token: 0x04002F40 RID: 12096
		[Token(Token = "0x4002F40")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _codeGetButton;

		// Token: 0x04002F41 RID: 12097
		[Token(Token = "0x4002F41")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _codeGetDescription;

		// Token: 0x02000DF6 RID: 3574
		[Token(Token = "0x2000DF6")]
		public enum States
		{
			// Token: 0x04002F43 RID: 12099
			[Token(Token = "0x4002F43")]
			UNKNOWN,
			// Token: 0x04002F44 RID: 12100
			[Token(Token = "0x4002F44")]
			GET_CODE,
			// Token: 0x04002F45 RID: 12101
			[Token(Token = "0x4002F45")]
			SET_CODE,
			// Token: 0x04002F46 RID: 12102
			[Token(Token = "0x4002F46")]
			SIGNIN
		}
	}
}
