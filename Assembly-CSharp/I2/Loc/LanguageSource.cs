using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200136A RID: 4970
	[Token(Token = "0x200136A")]
	[AddComponentMenu("I2/Localization/Source")]
	[ExecuteInEditMode]
	public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
	{
		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x060075EB RID: 30187 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060075EC RID: 30188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017A3")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x60075EB")]
			[Address(RVA = "0xBF74", Offset = "0xBF74", VA = "0xBF74", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60075EC")]
			[Address(RVA = "0xBF75", Offset = "0xBF75", VA = "0xBF75", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x14000306 RID: 774
		// (add) Token: 0x060075ED RID: 30189 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060075EE RID: 30190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000306")]
		public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x60075ED")]
			[Address(RVA = "0xBF76", Offset = "0xBF76", VA = "0xBF76")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60075EE")]
			[Address(RVA = "0xBF77", Offset = "0xBF77", VA = "0xBF77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060075EF RID: 30191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075EF")]
		[Address(RVA = "0xBF78", Offset = "0xBF78", VA = "0xBF78")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void I2_Loc_LanguageSource__Awake(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x18) = 0;
		  I2_Loc_LanguageSourceData__Awake(*(undefined4 *)(param1 + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x060075F0 RID: 30192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F0")]
		[Address(RVA = "0xBF79", Offset = "0xBF79", VA = "0xBF79")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		undefined4 I2_Loc_LanguageSource__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param3;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60476 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a60476 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  param3 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar1,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  while( true ) {
		    uVar1 = UnityEngine_Transform__set_parent(uVar1,0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar2 = UnityEngine_Component__GetComponent_object_(uVar1,0);
		    if (iVar2 == 0) break;
		    param1_00 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(uVar1,0);
		    param3 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                       (param1_00,StringLiteral_19176,param3,0);
		  }
		  return param3;
		}
		*/

		}

		// Token: 0x060075F1 RID: 30193 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075F1")]
		[Address(RVA = "0xBF7A", Offset = "0xBF7A", VA = "0xBF7A")]
		public string GetSourceName()
		{
		/* --- GHIDRA: GetSourceName ---
		void I2_Loc_LanguageSource__GetSourceName(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x14) = 1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060075F2 RID: 30194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F2")]
		[Address(RVA = "0xBF7B", Offset = "0xBF7B", VA = "0xBF7B", Slot = "4")]
		public void OnBeforeSerialize()
		{
		/* --- GHIDRA: OnBeforeSerialize ---
		void I2_Loc_LanguageSource__OnBeforeSerialize(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  int param3;
		  uint uVar6;
		  
		  if (DAT_ram_00a60477 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData__get_Item__);
		    DAT_ram_00a60477 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x14) == 0) || (*(int *)(param1 + 0x10) == 0)) {
		    iVar3 = unnamed_function_1417(I2_Loc_LanguageSourceData_TypeInfo);
		    I2_Loc_LanguageSourceData__ValidateFullTerm(iVar3,iVar3);
		    *(int *)(param1 + 0x10) = iVar3;
		    *(int *)(iVar3 + 8) = param1;
		    *(undefined1 *)(iVar3 + 0xc) = *(undefined1 *)(param1 + 0x19);
		    *(undefined1 *)(iVar3 + 0xd) = *(undefined1 *)(param1 + 0x1a);
		    *(undefined1 *)(iVar3 + 0x28) = *(undefined1 *)(param1 + 0x40);
		    *(undefined4 *)(iVar3 + 0x2c) = *(undefined4 *)(param1 + 0x44);
		    *(undefined1 *)(iVar3 + 0x14) = *(undefined1 *)(param1 + 0x4c);
		    *(undefined4 *)(iVar3 + 0x1c) = *(undefined4 *)(param1 + 0x50);
		    *(undefined4 *)(iVar3 + 0x20) = *(undefined4 *)(param1 + 0x54);
		    *(undefined1 *)(iVar3 + 0xe) = *(undefined1 *)(param1 + 0x1b);
		    *(undefined4 *)(iVar3 + 0x30) = *(undefined4 *)(param1 + 0x20);
		    *(undefined4 *)(iVar3 + 0x34) = *(undefined4 *)(param1 + 0x24);
		    *(undefined4 *)(iVar3 + 0x38) = *(undefined4 *)(param1 + 0x28);
		    *(undefined4 *)(iVar3 + 0x3c) = *(undefined4 *)(param1 + 0x2c);
		    *(undefined4 *)(iVar3 + 0x40) = *(undefined4 *)(param1 + 0x30);
		    *(undefined4 *)(iVar3 + 0x4c) = *(undefined4 *)(param1 + 0x34);
		    uVar5 = *(undefined4 *)(param1 + 0x38);
		    if (DAT_ram_00a6047b == '\0') {
		      Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSource_fnOnSourceUpdated_TypeInfo);
		      DAT_ram_00a6047b = '\x01';
		    }
		    iVar2 = *(int *)(iVar3 + 0x50);
		    do {
		      param1_00 = (int *)UnityEngine_UI_Image__set_sprite(iVar2,uVar5,0);
		      if ((param1_00 != (int *)0x0) &&
		         (I2_Loc_LanguageSource_fnOnSourceUpdated_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance(param1_00,I2_Loc_LanguageSource_fnOnSourceUpdated_TypeInfo)
		        ;
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar4 = func_ii_4329(iVar3 + 0x50,param1_00,iVar2);
		      bVar1 = iVar4 != iVar2;
		      iVar2 = iVar4;
		    } while (bVar1);
		    iVar3 = *(int *)(param1 + 0x3c);
		    if ((iVar3 != 0) && (0 < *(int *)(iVar3 + 0xc))) {
		      iVar4 = *(int *)(*(int *)(param1 + 0x10) + 0x24);
		      iVar2 = *(int *)(iVar4 + 0xc);
		      *(undefined4 *)(iVar4 + 0xc) = 0;
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      if (0 < iVar2) {
		        func_ii_2064(*(undefined4 *)(iVar4 + 8),0,iVar2,0);
		        iVar3 = *(int *)(param1 + 0x3c);
		        iVar4 = *(int *)(*(int *)(param1 + 0x10) + 0x24);
		      }
		      func_ii_6335(iVar4,iVar3,Method_System_Collections_Generic_List_LanguageData__AddRange__);
		      iVar3 = *(int *)(param1 + 0x3c);
		      iVar2 = *(int *)(iVar3 + 0xc);
		      *(undefined4 *)(iVar3 + 0xc) = 0;
		      *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		      if (0 < iVar2) {
		        func_ii_2064(*(undefined4 *)(iVar3 + 8),0,iVar2,0);
		      }
		    }
		    iVar3 = *(int *)(param1 + 0x1c);
		    if ((iVar3 != 0) && (0 < *(int *)(iVar3 + 0xc))) {
		      iVar4 = *(int *)(*(int *)(param1 + 0x10) + 0x54);
		      iVar2 = *(int *)(iVar4 + 0xc);
		      *(undefined4 *)(iVar4 + 0xc) = 0;
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      if (0 < iVar2) {
		        func_ii_2064(*(undefined4 *)(iVar4 + 8),0,iVar2,0);
		        iVar3 = *(int *)(param1 + 0x1c);
		        iVar4 = *(int *)(*(int *)(param1 + 0x10) + 0x54);
		      }
		      func_ii_6335(iVar4,iVar3,Method_System_Collections_Generic_List_Object__AddRange__);
		      iVar3 = *(int *)(param1 + 0x1c);
		      iVar2 = *(int *)(iVar3 + 0xc);
		      *(undefined4 *)(iVar3 + 0xc) = 0;
		      *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		      if (0 < iVar2) {
		        func_ii_2064(*(undefined4 *)(iVar3 + 8),0,iVar2,0);
		      }
		    }
		    iVar3 = *(int *)(param1 + 0x48);
		    if ((iVar3 != 0) && (0 < *(int *)(iVar3 + 0xc))) {
		      iVar4 = *(int *)(*(int *)(param1 + 0x10) + 0x10);
		      param3 = *(int *)(iVar4 + 0xc);
		      iVar2 = 0;
		      *(undefined4 *)(iVar4 + 0xc) = 0;
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      if (0 < param3) {
		        func_ii_2064(*(undefined4 *)(iVar4 + 8),0,param3,0);
		        iVar3 = *(int *)(param1 + 0x48);
		      }
		      if (*(int *)(iVar3 + 0xc) < 1) {
		        *(undefined4 *)(iVar3 + 0xc) = 0;
		        *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		      }
		      else {
		        do {
		          iVar4 = *(int *)(*(int *)(param1 + 0x10) + 0x10);
		          uVar5 = System_Linq_Enumerable__ToList_object_
		                            (iVar3,iVar2,Method_System_Collections_Generic_List_TermData__get_Item__
		                            );
		          iVar3 = Method_System_Collections_Generic_List_TermData__Add__;
		          *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		          uVar6 = *(uint *)(iVar4 + 0xc);
		          if (uVar6 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		            *(uint *)(iVar4 + 0xc) = uVar6 + 1;
		            *(undefined4 *)(*(int *)(iVar4 + 8) + uVar6 * 4 + 0x10) = uVar5;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (iVar4,uVar5,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		          }
		          iVar2 = iVar2 + 1;
		          iVar3 = *(int *)(param1 + 0x48);
		          iVar4 = *(int *)(iVar3 + 0xc);
		        } while (iVar2 < iVar4);
		        *(undefined4 *)(iVar3 + 0xc) = 0;
		        *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		        if (0 < iVar4) {
		          func_ii_2064(*(undefined4 *)(iVar3 + 8),0,iVar4,0);
		        }
		      }
		    }
		    *(undefined4 *)(param1 + 0x38) = 0;
		    *(undefined4 *)(param1 + 0x14) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060075F3 RID: 30195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F3")]
		[Address(RVA = "0xBF7C", Offset = "0xBF7C", VA = "0xBF7C", Slot = "5")]
		public void OnAfterDeserialize()
		{
		/* --- GHIDRA: OnAfterDeserialize ---
		void I2_Loc_LanguageSource__OnAfterDeserialize(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a60478 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSourceData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TermData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Object___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LanguageData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TermData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_LanguageData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Object__TypeInfo);
		    DAT_ram_00a60478 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(I2_Loc_LanguageSourceData_TypeInfo);
		  I2_Loc_LanguageSourceData__ValidateFullTerm(uVar1,param1);
		  *(undefined1 *)(param1 + 0x1b) = 1;
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_Object__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_Object___ctor__);
		  *(undefined8 *)(param1 + 0x30) = 0x40a0000000000003;
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_LanguageData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_LanguageData___ctor__);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_TermData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_TermData___ctor__);
		  *(undefined4 *)(param1 + 0x50) = 1;
		  *(undefined4 *)(param1 + 0x48) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060075F4 RID: 30196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F4")]
		[Address(RVA = "0xBF7D", Offset = "0xBF7D", VA = "0xBF7D")]
		public LanguageSource()
		{
		/* --- GHIDRA: .ctor ---
		void I2_Loc_LanguageSource___ctor(int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  uVar4 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar4;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (cVar1 == '\x02') {
		      if (*(char *)(param1 + 0x38) == '\0') {
		        *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Player_ram_000035bf + 0x29;
		      }
		      else {
		        iVar2 = unnamed_function_159288(param3);
		        iVar3 = func_ii_21171(param3);
		        if (iVar2 == 0) {
		          if (iVar3 == 0) {
		            *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Player_ram_000035bf + 0x28;
		          }
		          else {
		            *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Player_ram_000035bf + 0x27;
		          }
		        }
		        else if (iVar3 == 0) {
		          *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Player_ram_000035bf + 0x26;
		        }
		        else {
		          *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Player_ram_000035bf + 0x25;
		        }
		      }
		    }
		    else {
		      if (param2 == 0) {
		        uVar4 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                          (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		        func_ii_1050(uVar4,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		      *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		    }
		  }
		  else if (cVar1 == '\x03') {
		    *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Player_ram_000035bf + 0x24;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s___Scripting__UnityEngine__Player_ram_000035bf + 0x2a;
		  return;
		}
		*/

		}

		// Token: 0x04003DA1 RID: 15777
		[Token(Token = "0x4003DA1")]
		[FieldOffset(Offset = "0x10")]
		public LanguageSourceData mSource;

		// Token: 0x04003DA2 RID: 15778
		[Token(Token = "0x4003DA2")]
		[FieldOffset(Offset = "0x14")]
		public int version;

		// Token: 0x04003DA3 RID: 15779
		[Token(Token = "0x4003DA3")]
		[FieldOffset(Offset = "0x18")]
		public bool NeverDestroy;

		// Token: 0x04003DA4 RID: 15780
		[Token(Token = "0x4003DA4")]
		[FieldOffset(Offset = "0x19")]
		public bool UserAgreesToHaveItOnTheScene;

		// Token: 0x04003DA5 RID: 15781
		[Token(Token = "0x4003DA5")]
		[FieldOffset(Offset = "0x1A")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		// Token: 0x04003DA6 RID: 15782
		[Token(Token = "0x4003DA6")]
		[FieldOffset(Offset = "0x1B")]
		public bool GoogleLiveSyncIsUptoDate;

		// Token: 0x04003DA7 RID: 15783
		[Token(Token = "0x4003DA7")]
		[FieldOffset(Offset = "0x1C")]
		public List<UnityEngine.Object> Assets;

		// Token: 0x04003DA8 RID: 15784
		[Token(Token = "0x4003DA8")]
		[FieldOffset(Offset = "0x20")]
		public string Google_WebServiceURL;

		// Token: 0x04003DA9 RID: 15785
		[Token(Token = "0x4003DA9")]
		[FieldOffset(Offset = "0x24")]
		public string Google_SpreadsheetKey;

		// Token: 0x04003DAA RID: 15786
		[Token(Token = "0x4003DAA")]
		[FieldOffset(Offset = "0x28")]
		public string Google_SpreadsheetName;

		// Token: 0x04003DAB RID: 15787
		[Token(Token = "0x4003DAB")]
		[FieldOffset(Offset = "0x2C")]
		public string Google_LastUpdatedVersion;

		// Token: 0x04003DAC RID: 15788
		[Token(Token = "0x4003DAC")]
		[FieldOffset(Offset = "0x30")]
		public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;

		// Token: 0x04003DAD RID: 15789
		[Token(Token = "0x4003DAD")]
		[FieldOffset(Offset = "0x34")]
		public float GoogleUpdateDelay;

		// Token: 0x04003DAF RID: 15791
		[Token(Token = "0x4003DAF")]
		[FieldOffset(Offset = "0x3C")]
		public List<LanguageData> mLanguages;

		// Token: 0x04003DB0 RID: 15792
		[Token(Token = "0x4003DB0")]
		[FieldOffset(Offset = "0x40")]
		public bool IgnoreDeviceLanguage;

		// Token: 0x04003DB1 RID: 15793
		[Token(Token = "0x4003DB1")]
		[FieldOffset(Offset = "0x44")]
		public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;

		// Token: 0x04003DB2 RID: 15794
		[Token(Token = "0x4003DB2")]
		[FieldOffset(Offset = "0x48")]
		public List<TermData> mTerms;

		// Token: 0x04003DB3 RID: 15795
		[Token(Token = "0x4003DB3")]
		[FieldOffset(Offset = "0x4C")]
		public bool CaseInsensitiveTerms;

		// Token: 0x04003DB4 RID: 15796
		[Token(Token = "0x4003DB4")]
		[FieldOffset(Offset = "0x50")]
		public LanguageSourceData.MissingTranslationAction OnMissingTranslation;

		// Token: 0x04003DB5 RID: 15797
		[Token(Token = "0x4003DB5")]
		[FieldOffset(Offset = "0x54")]
		public string mTerm_AppName;

		// Token: 0x0200136B RID: 4971
		// (Invoke) Token: 0x060075F6 RID: 30198
		[Token(Token = "0x200136B")]
		public delegate void fnOnSourceUpdated(LanguageSourceData source, bool ReceivedNewData, string errorMsg);
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_SourceData ---
		void I2_Loc_LanguageSource__set_SourceData(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60474 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSource_fnOnSourceUpdated_TypeInfo);
		    DAT_ram_00a60474 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (I2_Loc_LanguageSource_fnOnSourceUpdated_TypeInfo == *param1_01)
		         )) {
		    iVar2 = func_ii_4329(param1 + 0x38,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,I2_Loc_LanguageSource_fnOnSourceUpdated_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_Event_OnSourceUpdateFromGoogle ---
		void I2_Loc_LanguageSource__add_Event_OnSourceUpdateFromGoogle
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a60475 == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LanguageSource_fnOnSourceUpdated_TypeInfo);
		    DAT_ram_00a60475 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (I2_Loc_LanguageSource_fnOnSourceUpdated_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x38,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,I2_Loc_LanguageSource_fnOnSourceUpdated_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_Event_OnSourceUpdateFromGoogle ---
		void I2_Loc_LanguageSource__remove_Event_OnSourceUpdateFromGoogle(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x10);
		  *(int *)(param1_00 + 8) = param1;
		  if (DAT_ram_00a6047d == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_LocalizationManager_TypeInfo);
		    DAT_ram_00a6047d = '\x01';
		  }
		  if (*(int *)(I2_Loc_LocalizationManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(I2_Loc_LocalizationManager_TypeInfo);
		  }
		  I2_Loc_LocalizationManager__AllowSyncFromGoogle(param1_00,param1_00);
		  I2_Loc_LanguageSourceData__DeserializeFullTerm(param1_00,0,param1_00);
		  I2_Loc_LanguageSourceData__Editor_SetDirty(param1_00,param1_00);
		  I2_Loc_LocalizationManager__GetAppName(1,param1_00);
		  return;
		}
		*/

}
