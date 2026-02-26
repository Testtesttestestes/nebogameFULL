using System;
using System.Collections.Generic;
using Gameplay.Accounts.Control;
using Gameplay.Accounts.Model.Data;
using Gameplay.Accounts.View.Accounts;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Accounts.View
{
	// Token: 0x02000DC5 RID: 3525
	[Token(Token = "0x2000DC5")]
	public class AccountWindow : ClosableBaseWindow<AccountWindow.AccountWindowArgs>
	{
		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06005602 RID: 22018 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700117B")]
		public override string WindowId
		{
			[Token(Token = "0x6005602")]
			[Address(RVA = "0xA3A2", Offset = "0xA3A2", VA = "0xA3A2", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005603 RID: 22019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005603")]
		[Address(RVA = "0xA3A3", Offset = "0xA3A3", VA = "0xA3A3", Slot = "24")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Accounts_View_AccountWindow__Awake(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58883 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_AccountWindow_AccountWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Type__AbstractAccountView__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_AbstractAccountView___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_DefaultAccountView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58883 = '\x01';
		  }
		  local_4 = 0;
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_AccountWindow_AccountWindowArgs__OnShow__);
		  uVar4 = *(undefined4 *)(param1 + 0x4c);
		  uVar1 = unnamed_function_143827(*(undefined4 *)(param2 + 0x1c));
		  iVar2 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (uVar4,uVar1,&local_4,
		                     Method_System_Collections_Generic_Dictionary_Type__AbstractAccountView__TryGetValue__
		                    );
		  uVar1 = local_4;
		  if (iVar2 == 0) {
		    uVar1 = *(undefined4 *)(param1 + 0x3c);
		    uVar4 = *(undefined4 *)(param1 + 0x40);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    piVar3 = (int *)func_ii_6805(uVar4,uVar1,
		                                 Method_UnityEngine_Object_Instantiate_DefaultAccountView___);
		  }
		  else {
		    uVar4 = *(undefined4 *)(param1 + 0x3c);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    piVar3 = (int *)func_ii_6805(uVar1,uVar4,
		                                 Method_UnityEngine_Object_Instantiate_AbstractAccountView___);
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xf8) * 4))
		            (piVar3,*(undefined4 *)(param2 + 0x18),*(undefined4 *)(param2 + 0x1c),
		             *(undefined4 *)(*piVar3 + 0xfc));
		  return;
		}
		*/

		}

		// Token: 0x06005604 RID: 22020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005604")]
		[Address(RVA = "0xA3A4", Offset = "0xA3A4", VA = "0xA3A4", Slot = "22")]
		protected override void OnShow(AccountWindow.AccountWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Accounts_View_AccountWindow__OnShow(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58884 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_AccountWindow_AccountWindowArgs___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__AbstractAccountView___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Type__AbstractAccountView__TypeInfo);
		    DAT_ram_00a58884 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_Type__AbstractAccountView__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_Type__AbstractAccountView___ctor__);
		  *(undefined4 *)(param1 + 0x4c) = param1_00;
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_AccountWindow_AccountWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06005605 RID: 22021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005605")]
		[Address(RVA = "0xA3A5", Offset = "0xA3A5", VA = "0xA3A5")]
		public AccountWindow()
		{
		}

		// Token: 0x04002E9B RID: 11931
		[Token(Token = "0x4002E9B")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Accounts/AccountWindow";

		// Token: 0x04002E9C RID: 11932
		[Token(Token = "0x4002E9C")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Transform _viewContainer;

		// Token: 0x04002E9D RID: 11933
		[Token(Token = "0x4002E9D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DefaultAccountView _defaultViewPrefab;

		// Token: 0x04002E9E RID: 11934
		[Token(Token = "0x4002E9E")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private DefaultAccountView _manufactureViewPrefab;

		// Token: 0x04002E9F RID: 11935
		[Token(Token = "0x4002E9F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AbstractAccountView _clanViewPrefab;

		// Token: 0x04002EA0 RID: 11936
		[Token(Token = "0x4002EA0")]
		[FieldOffset(Offset = "0x4C")]
		private Dictionary<Type, AbstractAccountView> _map;

		// Token: 0x02000DC6 RID: 3526
		[Token(Token = "0x2000DC6")]
		public class AccountWindowArgs : BaseWindowArgs
		{
			// Token: 0x06005606 RID: 22022 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005606")]
			[Address(RVA = "0xA3A6", Offset = "0xA3A6", VA = "0xA3A6")]
			public AccountWindowArgs()
			{
			}

			// Token: 0x04002EA1 RID: 11937
			[Token(Token = "0x4002EA1")]
			[FieldOffset(Offset = "0x18")]
			public AccountsController Controller;

			// Token: 0x04002EA2 RID: 11938
			[Token(Token = "0x4002EA2")]
			[FieldOffset(Offset = "0x1C")]
			public IAccountDataDecorator Account;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Accounts_View_AccountWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58882 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_ClanAccountGroup_var);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_AccountWindow_AccountWindowArgs__Awake__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Type__AbstractAccountView__Add__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_ManufactureAccount_var);
		    DAT_ram_00a58882 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object____ctor
		            (param1,Method_UI_Windows_ClosableBaseWindow_AccountWindow_AccountWindowArgs__Awake__);
		  uVar1 = Gameplay_Accounts_Model_Data_ClanAccountGroup_var;
		  uVar2 = *(undefined4 *)(param1 + 0x4c);
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar1 = func_ii_2734(uVar1,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar2,uVar1,*(undefined4 *)(param1 + 0x48),
		             Method_System_Collections_Generic_Dictionary_Type__AbstractAccountView__Add__);
		  uVar2 = *(undefined4 *)(param1 + 0x4c);
		  uVar1 = func_ii_2734(Gameplay_Accounts_Model_Data_ManufactureAccount_var,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar2,uVar1,*(undefined4 *)(param1 + 0x44),
		             Method_System_Collections_Generic_Dictionary_Type__AbstractAccountView__Add__);
		  return;
		}
		*/

}
