using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Auth2;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000E06 RID: 3590
	[Token(Token = "0x2000E06")]
	public class SignInVariants : MonoBehaviourWithStates<SignInVariants.States>
	{
		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06005778 RID: 22392 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011D4")]
		public Button SaveEmailPasswordButton
		{
			[Token(Token = "0x6005778")]
			[Address(RVA = "0xA4F3", Offset = "0xA4F3", VA = "0xA4F3")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06005779 RID: 22393 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011D5")]
		public TMP_InputField EmailTextField
		{
			[Token(Token = "0x6005779")]
			[Address(RVA = "0xA4F4", Offset = "0xA4F4", VA = "0xA4F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x0600577A RID: 22394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011D6")]
		public TMP_InputField PasswordTextField
		{
			[Token(Token = "0x600577A")]
			[Address(RVA = "0xA4F5", Offset = "0xA4F5", VA = "0xA4F5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x0600577B RID: 22395 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011D7")]
		public Button GpgsSigninButton
		{
			[Token(Token = "0x600577B")]
			[Address(RVA = "0xA4F6", Offset = "0xA4F6", VA = "0xA4F6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x0600577C RID: 22396 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011D8")]
		public OAuthProviderInvoker[] OAuthButtons
		{
			[Token(Token = "0x600577C")]
			[Address(RVA = "0xA4F7", Offset = "0xA4F7", VA = "0xA4F7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x0600577D RID: 22397 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011D9")]
		public TextMeshProUGUI StatusMessage
		{
			[Token(Token = "0x600577D")]
			[Address(RVA = "0xA4F8", Offset = "0xA4F8", VA = "0xA4F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x0600577E RID: 22398 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011DA")]
		public GameObject EmailOauthSignin
		{
			[Token(Token = "0x600577E")]
			[Address(RVA = "0xA4F9", Offset = "0xA4F9", VA = "0xA4F9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400020A RID: 522
		// (add) Token: 0x0600577F RID: 22399 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005780 RID: 22400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400020A")]
		public event Action<Provider> OnOAuthEvent
		{
			[Token(Token = "0x600577F")]
			[Address(RVA = "0xA4FA", Offset = "0xA4FA", VA = "0xA4FA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005780")]
			[Address(RVA = "0xA4FB", Offset = "0xA4FB", VA = "0xA4FB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x06005781 RID: 22401 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011DB")]
		public GameObject GoogleIcon
		{
			[Token(Token = "0x6005781")]
			[Address(RVA = "0xA4FC", Offset = "0xA4FC", VA = "0xA4FC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x06005782 RID: 22402 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011DC")]
		public GameObject HuaweiIcon
		{
			[Token(Token = "0x6005782")]
			[Address(RVA = "0xA4FD", Offset = "0xA4FD", VA = "0xA4FD")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005783 RID: 22403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005783")]
		[Address(RVA = "0xA4FE", Offset = "0xA4FE", VA = "0xA4FE")]
		public void InvokeOAuth(OAuthProviderInvoker provider)
		{
		/* --- GHIDRA: InvokeOAuth ---
		void Gameplay_AccountLinker_View_SignInVariants__InvokeOAuth(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5892d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_SignInVariants_States___ctor__);
		    DAT_ram_00a5892d = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_SignInVariants_States___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06005784 RID: 22404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005784")]
		[Address(RVA = "0xA4FF", Offset = "0xA4FF", VA = "0xA4FF")]
		public SignInVariants()
		{
		}

		// Token: 0x04002F64 RID: 12132
		[Token(Token = "0x4002F64")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _gpgsSigninButton;

		// Token: 0x04002F65 RID: 12133
		[Token(Token = "0x4002F65")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _saveEmailPasswordButton;

		// Token: 0x04002F66 RID: 12134
		[Token(Token = "0x4002F66")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TMP_InputField _emailTextField;

		// Token: 0x04002F67 RID: 12135
		[Token(Token = "0x4002F67")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TMP_InputField _passwordTextField;

		// Token: 0x04002F68 RID: 12136
		[Token(Token = "0x4002F68")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _statusMessage;

		// Token: 0x04002F69 RID: 12137
		[Token(Token = "0x4002F69")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _emailOauthSignin;

		// Token: 0x04002F6A RID: 12138
		[Token(Token = "0x4002F6A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private OAuthProviderInvoker[] _oAuthButtons;

		// Token: 0x04002F6B RID: 12139
		[Token(Token = "0x4002F6B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _googleIcon;

		// Token: 0x04002F6C RID: 12140
		[Token(Token = "0x4002F6C")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameObject _huaweiIcon;

		// Token: 0x02000E07 RID: 3591
		[Token(Token = "0x2000E07")]
		public enum States
		{
			// Token: 0x04002F6F RID: 12143
			[Token(Token = "0x4002F6F")]
			UNKNOWN,
			// Token: 0x04002F70 RID: 12144
			[Token(Token = "0x4002F70")]
			GPGS_SIGIN = 2,
			// Token: 0x04002F71 RID: 12145
			[Token(Token = "0x4002F71")]
			EMAIL_AND_OAUTH,
			// Token: 0x04002F72 RID: 12146
			[Token(Token = "0x4002F72")]
			GPGS_SIGIN_COMPLETE
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_EmailOauthSignin ---
		void Gameplay_AccountLinker_View_SignInVariants__get_EmailOauthSignin
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5892b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Provider__TypeInfo);
		    DAT_ram_00a5892b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_Provider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_Provider__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnOAuthEvent ---
		void Gameplay_AccountLinker_View_SignInVariants__add_OnOAuthEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5892c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Provider__TypeInfo);
		    DAT_ram_00a5892c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_Provider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_Provider__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_HuaweiIcon ---
		void Gameplay_AccountLinker_View_SignInVariants__get_HuaweiIcon
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x40);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0x10),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
