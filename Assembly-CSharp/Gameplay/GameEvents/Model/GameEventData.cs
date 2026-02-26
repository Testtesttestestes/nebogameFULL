using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Model.ActionsOnEvents;
using Gameplay.GameEvents.Model.Tags;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Events;

namespace Gameplay.GameEvents.Model
{
	// Token: 0x02000791 RID: 1937
	[Token(Token = "0x2000791")]
	public class GameEventData : IDisposable
	{
		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06002E06 RID: 11782 RVA: 0x00008D48 File Offset: 0x00006F48
		[Token(Token = "0x170008D7")]
		public bool IsRewardTaken
		{
			[Token(Token = "0x6002E06")]
			[Address(RVA = "0x7E84", Offset = "0x7E84", VA = "0x7E84")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06002E07 RID: 11783 RVA: 0x00008D60 File Offset: 0x00006F60
		[Token(Token = "0x170008D8")]
		public bool IsRead
		{
			[Token(Token = "0x6002E07")]
			[Address(RVA = "0x7E85", Offset = "0x7E85", VA = "0x7E85")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06002E08 RID: 11784 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E09 RID: 11785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D9")]
		public EventTypeDic EventTypeDic
		{
			[Token(Token = "0x6002E08")]
			[Address(RVA = "0x7E86", Offset = "0x7E86", VA = "0x7E86")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E09")]
			[Address(RVA = "0x7E87", Offset = "0x7E87", VA = "0x7E87")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E0A")]
		[Address(RVA = "0x7E88", Offset = "0x7E88", VA = "0x7E88", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_GameEvents_Model_GameEventData__Dispose
		               (int param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined8 param2_00;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a574b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AbstractTag__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22542);
		    DAT_ram_00a574b6 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_AbstractTag__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_AbstractTag___ctor__);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  *(undefined4 *)(param1 + 0x2c) = param4;
		  *(int *)(param1 + 0x24) = param3;
		  *(undefined4 *)(param1 + 0x20) = param2;
		  param2_00 = *(undefined8 *)(param3 + 0x18);
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  System_DateTimeOffset__FromUnixTimeSeconds(&local_20,param2_00,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  System_DateTimeOffset__ParseExact(&local_30,&local_10,0);
		  local_8 = local_28;
		  local_10 = local_30;
		  if (DAT_ram_00a63c4b == '\0') {
		    Mono_Security_ASN1__get_Item(&Localization_Culture_Culture_TypeInfo);
		    DAT_ram_00a63c4b = '\x01';
		  }
		  uVar1 = Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__GetBase64ZipContent
		                    (*(undefined4 *)(*(int *)(Localization_Culture_Culture_TypeInfo + 0x5c) + 4),0);
		  uVar1 = System_DateTimeOffset__ToString(&local_10,StringLiteral_22542,uVar1,0);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E0B")]
		[Address(RVA = "0x7E89", Offset = "0x7E89", VA = "0x7E89")]
		public GameEventData(EventTypeDic eventTypeDic, ProtoGetEventsListAns.Types.EventInfo eventInfo, List<AbstractTag> tags)
		{
		/* --- GHIDRA: .ctor ---
		/* WARNING: Removing unreachable block (ram,0x80d8fe68) */
		
		int Gameplay_GameEvents_Model_GameEventData___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *param1_00;
		  undefined4 param1_01;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 param1_02;
		  int iVar6;
		  int iVar7;
		  int param1_03;
		  undefined4 param3;
		  int iVar8;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar8 = 0;
		  param1_03 = *(int *)(param1 + 0x38);
		  if (param1_03 == 0) {
		    param1_03 = Core_Extensions_Dict_EventTypeDicExt__GetBigBannerAssetId
		                          (*(undefined4 *)(param1 + 0x20),0);
		    if (DAT_ram_00a574ba == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		      Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_Enumerator_AbstractTag__Dispose__);
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_Enumerator_AbstractTag__MoveNext__);
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_Enumerator_AbstractTag__get_Current__);
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_AbstractTag__GetEnumerator__);
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__get_Count__)
		      ;
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__get_Item__);
		      Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		      DAT_ram_00a574ba = '\x01';
		    }
		    local_8 = 0;
		    local_10 = 0;
		    local_14 = 0;
		    local_18 = 0;
		    iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (param1_03,0);
		    if (iVar2 == 0) {
		      if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Utils_StringUtils_TypeInfo);
		      }
		      param1_00 = (int *)System_Text_RegularExpressions_Regex__Matches
		                                   (*(undefined4 *)(*(int *)(Utils_StringUtils_TypeInfo + 0x5c) + 8)
		                                    ,param1_03,0);
		      param1_01 = unnamed_function_1417
		                            (System_Collections_Generic_Dictionary_string__string__TypeInfo);
		      System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		                (param1_01,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		      iVar2 = System_Text_RegularExpressions_MatchCollection__get_IsReadOnly(param1_00,0);
		      if (0 < iVar2) {
		        do {
		          iVar1 = 1;
		          piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(*param1_00 + 0x1d8) * 4))
		                                    (param1_00,iVar8,*(undefined4 *)(*param1_00 + 0x1dc));
		          uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xe8) * 4))
		                            (piVar3,*(undefined4 *)(*piVar3 + 0xec));
		          uVar4 = System_Text_RegularExpressions_GroupCollection__System_Collections_IList_RemoveAt
		                            (uVar4,1,0);
		          uVar4 = System_Text_RegularExpressions_Capture__set_Text(uVar4,0);
		          iVar5 = System_Net_WebConnection__ReadLine(uVar4,0x2d,0,0);
		          param3 = *(undefined4 *)(iVar5 + 0x10);
		          if (1 < *(int *)(iVar5 + 0xc)) {
		            iVar1 = func_ii_8697(*(undefined4 *)(iVar5 + 0x14),0);
		          }
		          System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                    (&local_28,*(undefined4 *)(param1 + 0x28),
		                     Method_System_Collections_Generic_List_AbstractTag__GetEnumerator__);
		          local_8 = local_20;
		          local_10 = local_28;
		          do {
		            do {
		              do {
		                DAT_ram_009d3e38 = 0;
		                iVar5 = import::env::invoke_iii
		                                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                                   Method_System_Collections_Generic_List_Enumerator_AbstractTag__MoveNext__
		                                  );
		                if (DAT_ram_009d3e38 == 1) goto code_r0x80d8fd2f;
		                if (iVar5 == 0) goto code_r0x80d8fd8c;
		              } while (local_8._4_4_[4] != iVar1);
		              DAT_ram_009d3e38 = 0;
		              iVar5 = import::env::invoke_iiiiiii
		                                (*(undefined4 *)(*local_8._4_4_ + 0xf8),local_8._4_4_,param3,param1,
		                                 &local_14,0,*(undefined4 *)(*local_8._4_4_ + 0xfc));
		              if (DAT_ram_009d3e38 == 1) goto code_r0x80d8fd2f;
		            } while (iVar5 == 0);
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x84,param1_01,uVar4,
		                       local_14,
		                       Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		          } while (DAT_ram_009d3e38 != 1);
		code_r0x80d8fd2f:
		          DAT_ram_009d3e38 = 0;
		          param1_02 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar5 = global_1;
		          iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar5 != iVar6) {
		            iVar5 = 0;
		code_r0x80d8fe3a:
		            DAT_ram_009d3e38 = 0;
		            if (iVar5 == 0) {
		              import::env::__resumeException(param1_02);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar5);
		            if (DAT_ram_009d3e38 != 1) {
		              do {
		                halt_trap();
		              } while( true );
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::__cxa_find_matching_catch_3(0);
		            unnamed_function_937();
		            do {
		              halt_trap();
		            } while( true );
		          }
		          piVar3 = (int *)import::env::__cxa_begin_catch(param1_02);
		          iVar5 = *piVar3;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_v(0x123);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 == 1) {
		            param1_02 = import::env::__cxa_find_matching_catch_2();
		            goto code_r0x80d8fe3a;
		          }
		          if (iVar5 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80d8fd8c:
		          DAT_ram_009d3e38 = 0;
		          iVar5 = 0;
		          iVar6 = *(int *)(*(int *)(param1 + 0x2c) + 0xc);
		          if (0 < iVar6) {
		            do {
		              piVar3 = (int *)System_Linq_Enumerable__ToList_object_
		                                        (*(undefined4 *)(param1 + 0x2c),iVar5,
		                                         Method_System_Collections_Generic_List_AbstractTag__get_Item__
		                                        );
		              if ((piVar3[4] == iVar1) &&
		                 (iVar7 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xf8) * 4))
		                                    (piVar3,param3,param1,&local_18,0,
		                                     *(undefined4 *)(*piVar3 + 0xfc)), iVar7 != 0)) {
		                func_ii_2946(param1_01,uVar4,local_18,
		                             Method_System_Collections_Generic_Dictionary_string__string__set_Item__
		                            );
		              }
		              iVar5 = iVar5 + 1;
		            } while (iVar5 != iVar6);
		          }
		          iVar8 = iVar8 + 1;
		        } while (iVar8 != iVar2);
		      }
		      param1_03 = Core_GameLocalization__GetTranslation(param1_03,param1_01,0);
		    }
		    *(int *)(param1 + 0x38) = param1_03;
		  }
		  return param1_03;
		}
		*/

		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06002E0C RID: 11788 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008DA")]
		public string Title
		{
			[Token(Token = "0x6002E0C")]
			[Address(RVA = "0x7E8A", Offset = "0x7E8A", VA = "0x7E8A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x00008D78 File Offset: 0x00006F78
		[Token(Token = "0x170008DB")]
		public bool ContainsArtifactRewards
		{
			[Token(Token = "0x6002E0D")]
			[Address(RVA = "0x1ACD", Offset = "0x1ACD", VA = "0x1ACD")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06002E0E RID: 11790 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E0F RID: 11791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008DC")]
		public AssetDic SoundAssetShowInReadView
		{
			[Token(Token = "0x6002E0E")]
			[Address(RVA = "0x7E8B", Offset = "0x7E8B", VA = "0x7E8B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E0F")]
			[Address(RVA = "0x7E8C", Offset = "0x7E8C", VA = "0x7E8C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x00008D90 File Offset: 0x00006F90
		[Token(Token = "0x6002E10")]
		[Address(RVA = "0x7E8D", Offset = "0x7E8D", VA = "0x7E8D")]
		public bool TryResetArtifactFromRewardCache(ArtifactInfo artifactInfo)
		{
		/* --- GHIDRA: TryResetArtifactFromRewardCache ---
		undefined4
		Gameplay_GameEvents_Model_GameEventData__TryResetArtifactFromRewardCache
		          (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a574b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__get_Item__);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19134);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24405);
		    DAT_ram_00a574b9 = '\x01';
		  }
		  *param2 = 0;
		  iVar3 = *(int *)(*(int *)(param1 + 0x24) + 0x38);
		  if (3 < *(int *)(iVar3 + 0xc)) {
		    iVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (iVar3,3,Method_Google_Protobuf_Collections_RepeatedField_string__get_Item__);
		    iVar2 = func_ii_7903(iVar3,StringLiteral_24405,0);
		    if (iVar2 != 0) {
		      param1_00 = System_Data_DataSet__ReadXmlSchema(iVar3,1,*(int *)(iVar3 + 8) + -2,0);
		      iVar3 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		      *(undefined4 *)(iVar3 + 0x10) = StringLiteral_19134;
		      iVar3 = System_UriBuilder___ctor(param1_00,iVar3,1,0);
		      if ((*(int *)(iVar3 + 0xc) != 0) &&
		         (iVar3 = System_Net_WebConnection__ReadLine(*(undefined4 *)(iVar3 + 0x10),0x3b,0,0),
		         *(int *)(iVar3 + 0xc) == 5)) {
		        *param2 = *(undefined4 *)(iVar3 + 0x20);
		        uVar1 = 1;
		      }
		    }
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x00008DA8 File Offset: 0x00006FA8
		[Token(Token = "0x6002E11")]
		[Address(RVA = "0x7E8E", Offset = "0x7E8E", VA = "0x7E8E")]
		public bool TryGetInfoPageURL(out string url)
		{
		/* --- GHIDRA: TryGetInfoPageURL ---
		undefined4
		Gameplay_GameEvents_Model_GameEventData__TryGetInfoPageURL
		          (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  int *param1_00;
		  undefined4 param1_01;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 param1_02;
		  int iVar6;
		  int iVar7;
		  undefined4 param3_00;
		  int iVar8;
		  int local_28;
		  undefined8 *puStack_24;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a574ba == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AbstractTag__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AbstractTag__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AbstractTag__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractTag__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__get_Item__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    DAT_ram_00a574ba = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = 0;
		  local_18 = 0;
		  iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param1,0);
		  if (iVar2 == 0) {
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    param1_00 = (int *)System_Text_RegularExpressions_Regex__Matches
		                                 (*(undefined4 *)(*(int *)(Utils_StringUtils_TypeInfo + 0x5c) + 8),
		                                  param1,0);
		    param1_01 = unnamed_function_1417
		                          (System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (param1_01,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    iVar2 = System_Text_RegularExpressions_MatchCollection__get_IsReadOnly(param1_00,0);
		    if (0 < iVar2) {
		      do {
		        iVar1 = 1;
		        piVar3 = (int *)(**(code **)((ulonglong)*(uint *)(*param1_00 + 0x1d8) * 4))
		                                  (param1_00,iVar8,*(undefined4 *)(*param1_00 + 0x1dc));
		        uVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xe8) * 4))
		                          (piVar3,*(undefined4 *)(*piVar3 + 0xec));
		        uVar4 = System_Text_RegularExpressions_GroupCollection__System_Collections_IList_RemoveAt
		                          (uVar4,1,0);
		        uVar4 = System_Text_RegularExpressions_Capture__set_Text(uVar4,0);
		        iVar5 = System_Net_WebConnection__ReadLine(uVar4,0x2d,0,0);
		        param3_00 = *(undefined4 *)(iVar5 + 0x10);
		        if (1 < *(int *)(iVar5 + 0xc)) {
		          iVar1 = func_ii_8697(*(undefined4 *)(iVar5 + 0x14),0);
		        }
		        System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                  (&local_28,*(undefined4 *)(param2 + 0x28),
		                   Method_System_Collections_Generic_List_AbstractTag__GetEnumerator__);
		        local_8 = local_20;
		        local_10 = CONCAT44(puStack_24,local_28);
		        local_28 = 0;
		        puStack_24 = &local_10;
		        do {
		          do {
		            do {
		              DAT_ram_009d3e38 = 0;
		              iVar5 = import::env::invoke_iii
		                                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                                 Method_System_Collections_Generic_List_Enumerator_AbstractTag__MoveNext__
		                                );
		              if (DAT_ram_009d3e38 == 1) goto code_r0x80d8dc90;
		              if (iVar5 == 0) goto code_r0x80d8dced;
		            } while (local_8._4_4_[4] != iVar1);
		            DAT_ram_009d3e38 = 0;
		            iVar5 = import::env::invoke_iiiiiii
		                              (*(undefined4 *)(*local_8._4_4_ + 0xf8),local_8._4_4_,param3_00,param2
		                               ,&local_14,param3,*(undefined4 *)(*local_8._4_4_ + 0xfc));
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80d8dc90;
		          } while (iVar5 == 0);
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x84,param1_01,uVar4,local_14
		                     ,Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		        } while (DAT_ram_009d3e38 != 1);
		code_r0x80d8dc90:
		        DAT_ram_009d3e38 = 0;
		        param1_02 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar5 = global_1;
		        iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar5 != iVar6) {
		code_r0x80d8dd93:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2d1,&local_28);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            import::env::__cxa_find_matching_catch_3(0);
		            unnamed_function_937();
		            do {
		              halt_trap();
		            } while( true );
		          }
		          import::env::__resumeException(param1_02);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        piVar3 = (int *)import::env::__cxa_begin_catch(param1_02);
		        iVar6 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_28 = iVar6;
		        import::env::invoke_v(0x123);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          param1_02 = import::env::__cxa_find_matching_catch_2();
		          goto code_r0x80d8dd93;
		        }
		        if (iVar6 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		          do {
		            halt_trap();
		          } while( true );
		        }
		code_r0x80d8dced:
		        DAT_ram_009d3e38 = 0;
		        iVar5 = 0;
		        iVar6 = *(int *)(*(int *)(param2 + 0x2c) + 0xc);
		        if (0 < iVar6) {
		          do {
		            piVar3 = (int *)System_Linq_Enumerable__ToList_object_
		                                      (*(undefined4 *)(param2 + 0x2c),iVar5,
		                                       Method_System_Collections_Generic_List_AbstractTag__get_Item__
		                                      );
		            if ((piVar3[4] == iVar1) &&
		               (iVar7 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xf8) * 4))
		                                  (piVar3,param3_00,param2,&local_18,param3,
		                                   *(undefined4 *)(*piVar3 + 0xfc)), iVar7 != 0)) {
		              func_ii_2946(param1_01,uVar4,local_18,
		                           Method_System_Collections_Generic_Dictionary_string__string__set_Item__);
		            }
		            iVar5 = iVar5 + 1;
		          } while (iVar5 != iVar6);
		        }
		        iVar8 = iVar8 + 1;
		      } while (iVar8 != iVar2);
		    }
		    param1 = Core_GameLocalization__GetTranslation(param1,param1_01,0);
		  }
		  return param1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E12")]
		[Address(RVA = "0x7E8F", Offset = "0x7E8F", VA = "0x7E8F")]
		public static string Parse(string text, GameEventData eventData, AbstractTag.TagViewHandler viewHandler)
		{
		/* --- GHIDRA: Parse ---
		undefined4 Gameplay_GameEvents_Model_GameEventData__Parse(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(param1 + 8),0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (*(undefined4 *)(param1 + 0xc),0);
		    if (iVar1 == 0) {
		      uVar2 = 0;
		    }
		    else {
		      iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                        (*(undefined4 *)(param1 + 0x10),0);
		      if (iVar1 == 0) {
		        uVar2 = 0;
		      }
		      else {
		        uVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                          (*(undefined4 *)(param1 + 0x14),0);
		      }
		    }
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x04001937 RID: 6455
		[Token(Token = "0x4001937")]
		[FieldOffset(Offset = "0x8")]
		public bool HasBeenViewed;

		// Token: 0x04001938 RID: 6456
		[Token(Token = "0x4001938")]
		[FieldOffset(Offset = "0xC")]
		public readonly string DateString;

		// Token: 0x04001939 RID: 6457
		[Token(Token = "0x4001939")]
		[FieldOffset(Offset = "0x10")]
		public GameEventData.GameEventBackground EventBackground;

		// Token: 0x0400193A RID: 6458
		[Token(Token = "0x400193A")]
		[FieldOffset(Offset = "0x14")]
		public int ViewedCount;

		// Token: 0x0400193B RID: 6459
		[Token(Token = "0x400193B")]
		[FieldOffset(Offset = "0x18")]
		public GameEventsModel Model;

		// Token: 0x0400193C RID: 6460
		[Token(Token = "0x400193C")]
		[FieldOffset(Offset = "0x1C")]
		public EventCategoriesDic Category;

		// Token: 0x0400193E RID: 6462
		[Token(Token = "0x400193E")]
		[FieldOffset(Offset = "0x24")]
		public ProtoGetEventsListAns.Types.EventInfo EventInfo;

		// Token: 0x0400193F RID: 6463
		[Token(Token = "0x400193F")]
		[FieldOffset(Offset = "0x28")]
		public List<AbstractTag> SourceTags;

		// Token: 0x04001940 RID: 6464
		[Token(Token = "0x4001940")]
		[FieldOffset(Offset = "0x2C")]
		public List<AbstractTag> Tags;

		// Token: 0x04001941 RID: 6465
		[Token(Token = "0x4001941")]
		[FieldOffset(Offset = "0x30")]
		public RepeatedField<ArtifactInfo> ArtifactsFromRewardCache;

		// Token: 0x04001942 RID: 6466
		[Token(Token = "0x4001942")]
		[FieldOffset(Offset = "0x34")]
		public List<AbstractActionOnEvent> ActionsOnEvent;

		// Token: 0x04001943 RID: 6467
		[Token(Token = "0x4001943")]
		[FieldOffset(Offset = "0x38")]
		private string _title;

		// Token: 0x02000792 RID: 1938
		[Token(Token = "0x2000792")]
		public class GameEventBackground
		{
			// Token: 0x170008DD RID: 2269
			// (get) Token: 0x06002E13 RID: 11795 RVA: 0x00008DC0 File Offset: 0x00006FC0
			[Token(Token = "0x170008DD")]
			public bool IsEmpty
			{
				[Token(Token = "0x6002E13")]
				[Address(RVA = "0x7E90", Offset = "0x7E90", VA = "0x7E90")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06002E14 RID: 11796 RVA: 0x00008DD8 File Offset: 0x00006FD8
			[Token(Token = "0x6002E14")]
			[Address(RVA = "0x7E91", Offset = "0x7E91", VA = "0x7E91")]
			public bool TryGetAssetId(out string eventBannerListAssetId, out string eventBannerAssetId)
			{
				return default(bool);
			}

			// Token: 0x06002E15 RID: 11797 RVA: 0x00008DF0 File Offset: 0x00006FF0
			[Token(Token = "0x6002E15")]
			[Address(RVA = "0x7E92", Offset = "0x7E92", VA = "0x7E92")]
			public bool TryGetAssetPath(out string eventBannerListAssetPath, out string eventBannerAssetPath)
			{
				return default(bool);
			}

			// Token: 0x06002E16 RID: 11798 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002E16")]
			[Address(RVA = "0x7E93", Offset = "0x7E93", VA = "0x7E93")]
			public GameEventBackground()
			{
			}

			// Token: 0x04001945 RID: 6469
			[Token(Token = "0x4001945")]
			[FieldOffset(Offset = "0x8")]
			public string EventBannerPath;

			// Token: 0x04001946 RID: 6470
			[Token(Token = "0x4001946")]
			[FieldOffset(Offset = "0xC")]
			public string EventListBannerPath;

			// Token: 0x04001947 RID: 6471
			[Token(Token = "0x4001947")]
			[FieldOffset(Offset = "0x10")]
			public string EventBannerAssetId;

			// Token: 0x04001948 RID: 6472
			[Token(Token = "0x4001948")]
			[FieldOffset(Offset = "0x14")]
			public string EventListBannerAssetId;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsRewardTaken ---
		undefined4 Gameplay_GameEvents_Model_GameEventData__get_IsRewardTaken(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  local_4 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0x24);
		  uVar1 = UnityEngine_InputForUI_PointerEvent_ButtonsState__Set(&local_4,1,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: set_EventTypeDic ---
		void Gameplay_GameEvents_Model_GameEventData__set_EventTypeDic(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a574b5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractActionOnEvent__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractActionOnEvent__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractActionOnEvent__get_Item__);
		    DAT_ram_00a574b5 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x2c);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (iVar2,iVar1,Method_System_Collections_Generic_List_AbstractTag__get_Item__)
		      ;
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		      *(undefined8 *)(iVar2 + 8) = 0;
		      iVar1 = iVar1 + 1;
		      iVar2 = *(int *)(param1 + 0x2c);
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  piVar3 = (int *)(param1 + 0x28);
		  iVar1 = *(int *)(param1 + 0x28);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    iVar2 = 0;
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,iVar2,Method_System_Collections_Generic_List_AbstractTag__get_Item__)
		      ;
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		      *(undefined8 *)(iVar1 + 8) = 0;
		      iVar2 = iVar2 + 1;
		      iVar1 = *piVar3;
		    } while (iVar2 < *(int *)(iVar1 + 0xc));
		  }
		  iVar1 = *(int *)(param1 + 0x34);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    iVar2 = 0;
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,iVar2,
		                         Method_System_Collections_Generic_List_AbstractActionOnEvent__get_Item__);
		      *(undefined8 *)(iVar1 + 8) = 0;
		      *(undefined4 *)(iVar1 + 0x10) = 0;
		      iVar2 = iVar2 + 1;
		      iVar1 = *(int *)(param1 + 0x34);
		    } while (iVar2 < *(int *)(iVar1 + 0xc));
		  }
		  iVar1 = *(int *)(param1 + 0x2c);
		  iVar2 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < iVar2) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,iVar2,0);
		  }
		  iVar1 = *piVar3;
		  iVar2 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < iVar2) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,iVar2,0);
		  }
		  iVar1 = *(int *)(param1 + 0x34);
		  iVar2 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < iVar2) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,iVar2,0);
		  }
		  *(undefined4 *)(param1 + 0x20) = 0;
		  *(undefined4 *)(param1 + 0x10) = 0;
		  *(undefined8 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x30) = 0;
		  piVar3[0] = 0;
		  piVar3[1] = 0;
		  return;
		}
		*/


		/* --- GHIDRA: get_ContainsArtifactRewards ---
		void Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		               (int *param1,int param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  int iVar3;
		  int param2_00;
		  int iVar4;
		  int *piVar5;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a599d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Tabs_ITabBarItemView_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ITabBarItemView__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ITabBarItemView__get_Item__);
		    DAT_ram_00a599d3 = '\x01';
		  }
		  iVar3 = param1[0x11];
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    param1[0xf] = param2;
		    do {
		      param1_00 = (int *)System_Linq_Enumerable__ToList_object_
		                                   (iVar3,param2_00,
		                                    Method_System_Collections_Generic_List_ITabBarItemView__get_Item__
		                                   );
		      iVar3 = param1[0xf];
		      iVar4 = *param1_00;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar5 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		          if (UI_Tabs_ITabBarItemView_TypeInfo == *piVar5) {
		            puVar2 = (uint *)(piVar5[1] * 8 + iVar4 + 0xd8);
		            goto code_r0x810a0ae8;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param1_00,UI_Tabs_ITabBarItemView_TypeInfo,3);
		code_r0x810a0ae8:
		      (**(code **)((ulonglong)*puVar2 * 4))(param1_00,iVar3 == param2_00,puVar2[1]);
		      iVar3 = *param1_00;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar5 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		          if (UI_Tabs_ITabBarItemView_TypeInfo == *piVar5) {
		            puVar2 = (uint *)(piVar5[1] * 8 + iVar3 + 0xd0);
		            goto code_r0x810a0b60;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param1_00,UI_Tabs_ITabBarItemView_TypeInfo,2);
		code_r0x810a0b60:
		      iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		      if (iVar3 != 0) {
		        param1[0xc] = (int)param1_00;
		      }
		      param2_00 = param2_00 + 1;
		      iVar3 = param1[0x11];
		    } while (param2_00 < *(int *)(iVar3 + 0xc));
		    if ((param3 == 0) && (iVar3 = param1[4], iVar3 != 0)) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		    }
		    System_Linq_Enumerable__First_object_(param1[10],(uint)(0 < param1[0xf]),0);
		    System_Linq_Enumerable__First_object_
		              (param1[0xb],(uint)(param1[0xf] < *(int *)(param1[0x11] + 0xc) + -1),0);
		    UI_Tabs_TabBar__PrevButtonClicked(param1,iVar3);
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(param1,*(undefined4 *)(*param1 + 0xf4));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_SoundAssetShowInReadView ---
		undefined4
		Gameplay_GameEvents_Model_GameEventData__set_SoundAssetShowInReadView
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a574b8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__IndexOf__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__RemoveAt__);
		    DAT_ram_00a574b8 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x30) != 0) &&
		     (param2_00 = Google_Protobuf_Collections_RepeatedField_object___GetHashCode
		                            (*(int *)(param1 + 0x30),param2,
		                             Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__IndexOf__
		                            ), param2_00 != -1)) {
		    Google_Protobuf_Collections_RepeatedField_object___Insert
		              (*(undefined4 *)(param1 + 0x30),param2_00,
		               Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__RemoveAt__);
		    uVar1 = 1;
		  }
		  return uVar1;
		}
		*/

}
