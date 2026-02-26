using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Skills;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Core.Gameplay;
using Gameplay.Inventory.Model;
using Gameplay.User.Model;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;

namespace Gameplay.UserInfo.Model
{
	// Token: 0x02000413 RID: 1043
	[Token(Token = "0x2000413")]
	public class UserInfoModel : AbstractModel
	{
		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600186D RID: 6253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000451")]
		public UserModel UserModel
		{
			[Token(Token = "0x600186C")]
			[Address(RVA = "0x6A0C", Offset = "0x6A0C", VA = "0x6A0C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600186D")]
			[Address(RVA = "0x6A0D", Offset = "0x6A0D", VA = "0x6A0D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000452")]
		public UserData LoggedUser
		{
			[Token(Token = "0x600186E")]
			[Address(RVA = "0x6A0E", Offset = "0x6A0E", VA = "0x6A0E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x000056D0 File Offset: 0x000038D0
		[Token(Token = "0x17000453")]
		public bool IsGuest
		{
			[Token(Token = "0x600186F")]
			[Address(RVA = "0x6A0F", Offset = "0x6A0F", VA = "0x6A0F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001871 RID: 6257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000454")]
		public IGame Game
		{
			[Token(Token = "0x6001870")]
			[Address(RVA = "0x6A10", Offset = "0x6A10", VA = "0x6A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001871")]
			[Address(RVA = "0x6A11", Offset = "0x6A11", VA = "0x6A11")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000455")]
		public ServiceOptionsDic PriceOfChangeGenderAndCult
		{
			[Token(Token = "0x6001872")]
			[Address(RVA = "0x6A12", Offset = "0x6A12", VA = "0x6A12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001874 RID: 6260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000456")]
		public ResourceSet PriceOfChangeNick
		{
			[Token(Token = "0x6001873")]
			[Address(RVA = "0x6A13", Offset = "0x6A13", VA = "0x6A13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001874")]
			[Address(RVA = "0x6A14", Offset = "0x6A14", VA = "0x6A14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001876 RID: 6262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000457")]
		public AprDicWrapper CurrentSelectedApr
		{
			[Token(Token = "0x6001875")]
			[Address(RVA = "0x6A15", Offset = "0x6A15", VA = "0x6A15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001876")]
			[Address(RVA = "0x6A16", Offset = "0x6A16", VA = "0x6A16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001877")]
		[Address(RVA = "0x6A17", Offset = "0x6A17", VA = "0x6A17", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_UserInfo_Model_UserInfoModel__Dispose
		               (int param1,undefined4 param2,int param3,int param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int param2_00;
		  int *piVar5;
		  int iVar6;
		  int param1_00;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  int iVar9;
		  int *piVar10;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a59904 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Genders__Dictionary_uint__AprDicWrapper___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprDicWrapper__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprDicWrapper___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Genders__Dictionary_uint__AprDicWrapper____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Genders__Dictionary_uint__AprDicWrapper___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_Genders__Dictionary_uint__AprDicWrapper___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__AprDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GenderDic__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GenderDic___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GenderDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_CultDic__Add__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_CultDic___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RegistrationAprsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_GenderDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_GenderDic__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RegistrationAprsDic__get_Item__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_RepeatedField_CultDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_SkillCollection_TypeInfo);
		    DAT_ram_00a59904 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Core_Data_Skills_SkillCollection_TypeInfo);
		  Core_Data_Skills_EffectSkillsMapping___cctor(uVar2,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param3,0);
		  *(undefined4 *)(param1 + 0x28) = param5;
		  *(int *)(param1 + 0xc) = param4;
		  *(undefined4 *)(param1 + 0x2c) = param2;
		  if (*(int *)(param4 + 8) != param3) {
		    return;
		  }
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_Genders__Dictionary_uint__AprDicWrapper___TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_Genders__Dictionary_uint__AprDicWrapper____ctor__
		            );
		  *(undefined4 *)(param1 + 0x24) = uVar2;
		  uVar2 = unnamed_function_1417(Google_Protobuf_Collections_RepeatedField_CultDic__TypeInfo);
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		            (uVar2,Method_Google_Protobuf_Collections_RepeatedField_CultDic___ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  iVar3 = Gameplay_User_Model_UserModel__set_RequestedClanId(*(undefined4 *)(param1 + 0xc),uVar2);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      uVar2 = *(undefined4 *)(iVar3 + iVar6 * 4 + 0x10);
		      uVar7 = *(undefined4 *)(param1 + 0x18);
		      piVar5 = *(int **)(param1 + 0x28);
		      iVar9 = *piVar5;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		            puVar4 = (uint *)(piVar10[1] * 8 + iVar9 + 0x178);
		            goto code_r0x8108b6b5;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8108b6b5:
		      uVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		      uVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar8,0);
		      uVar2 = Core_Extensions_Dict_DictExt__GetAllArtikulTypeMetaFilterByType(uVar8,uVar2,0);
		      func_ii_6441(uVar7,uVar2,Method_Google_Protobuf_Collections_RepeatedField_CultDic__Add__);
		      iVar6 = iVar6 + 1;
		    } while (iVar6 < *(int *)(iVar3 + 0xc));
		  }
		  uVar1 = 0;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_GenderDic__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_GenderDic___ctor__);
		  *(undefined4 *)(param1 + 0x20) = uVar2;
		  piVar5 = *(int **)(param1 + 0x28);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x8108b784;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8108b784:
		  iVar6 = 0;
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		  iVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  iVar3 = *(int *)(iVar3 + 0x27c);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      param2_00 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                            (iVar3,iVar6,
		                             Method_Google_Protobuf_Collections_RepeatedField_GenderDic__get_Item__)
		      ;
		      iVar9 = Method_System_Collections_Generic_List_GenderDic__Add__;
		      param1_00 = *(int *)(param1 + 0x20);
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar1 = *(uint *)(param1_00 + 0xc);
		      if (uVar1 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar1 + 1;
		        *(int *)(*(int *)(param1_00 + 8) + uVar1 * 4 + 0x10) = param2_00;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,param2_00,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		      }
		      uVar7 = *(undefined4 *)(param2_00 + 0xc);
		      uVar8 = *(undefined4 *)(param1 + 0x24);
		      uVar2 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_uint__AprDicWrapper__TypeInfo);
		      System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		                (uVar2,Method_System_Collections_Generic_Dictionary_uint__AprDicWrapper___ctor__);
		      func_ii_10812(uVar8,uVar7,uVar2,
		                    Method_System_Collections_Generic_Dictionary_Genders__Dictionary_uint__AprDicWrapper___Add__
		                   );
		      iVar6 = iVar6 + 1;
		    } while (iVar6 < *(int *)(iVar3 + 0xc));
		  }
		  iVar6 = 0;
		  do {
		    piVar5 = *(int **)(param1 + 0x28);
		    iVar3 = *piVar5;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		          puVar4 = (uint *)(piVar10[1] * 8 + iVar3 + 0x178);
		          goto code_r0x8108b8dd;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8108b8dd:
		    uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		    iVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		    if (*(int *)(*(int *)(iVar3 + 0x1c0) + 0xc) <= iVar6) {
		      return;
		    }
		    piVar5 = *(int **)(param1 + 0x28);
		    iVar3 = *piVar5;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		          puVar4 = (uint *)(piVar10[1] * 8 + iVar3 + 0x178);
		          goto code_r0x8108b96e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8108b96e:
		    uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		    iVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		    iVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(iVar3 + 0x1c0),iVar6,
		                       Method_Google_Protobuf_Collections_RepeatedField_RegistrationAprsDic__get_Item__
		                      );
		    piVar5 = *(int **)(param1 + 0x28);
		    iVar9 = *piVar5;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		          puVar4 = (uint *)(piVar10[1] * 8 + iVar9 + 0x178);
		          goto code_r0x8108ba07;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8108ba07:
		    iVar9 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		    iVar3 = func_ii_7730(*(undefined4 *)(*(int *)(iVar9 + 0x24) + 0x14),*(undefined4 *)(iVar3 + 0xc)
		                         ,
		                         Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		                        );
		    uVar2 = GAFInternal_Reader_GAFReader__OpenTag
		                      (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(*(int *)(iVar3 + 0x10) + 0x10)
		                       ,
		                       Method_System_Collections_Generic_Dictionary_Genders__Dictionary_uint__AprDicWrapper___get_Item__
		                      );
		    System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		              (uVar2,*(undefined4 *)(*(int *)(iVar3 + 0x10) + 0x14),iVar3,
		               Method_System_Collections_Generic_Dictionary_uint__AprDicWrapper__Add__);
		    iVar6 = iVar6 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001878")]
		[Address(RVA = "0x6A18", Offset = "0x6A18", VA = "0x6A18")]
		public UserInfoModel(IDictProvider dictProvider, UserData user, UserModel userModel, IGame gameInstance)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_UserInfo_Model_UserInfoModel___ctor(int param1,longlong *param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  *param2 = 0;
		  if (*(int *)(param1 + 8) == *(int *)(*(int *)(param1 + 0xc) + 8)) {
		    iVar1 = Gameplay_User_Model_UserModel__get_ExperienceProgress(*(int *)(param1 + 0xc),param1);
		    if (iVar1 == 0) {
		      return 0;
		    }
		    iVar1 = Gameplay_User_Model_UserModel__get_ExperienceProgress
		                      (*(undefined4 *)(param1 + 0xc),param1);
		    *param2 = *(longlong *)(iVar1 + 0x10) - *(longlong *)(*(int *)(param1 + 8) + 0x58);
		  }
		  return 1;
		}
		*/

		}

		// Token: 0x06001879 RID: 6265 RVA: 0x000056E8 File Offset: 0x000038E8
		[Token(Token = "0x6001879")]
		[Address(RVA = "0x6A19", Offset = "0x6A19", VA = "0x6A19")]
		public bool TryGetExpRemainOnNextLevel(out ulong value)
		{
		/* --- GHIDRA: TryGetExpRemainOnNextLevel ---
		float Gameplay_UserInfo_Model_UserInfoModel__TryGetExpRemainOnNextLevel
		                (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  float fVar2;
		  ulonglong uVar3;
		  int iVar4;
		  
		  iVar4 = *(int *)(param1 + 0xc);
		  if (*(int *)(param1 + 8) == *(int *)(iVar4 + 8)) {
		    iVar1 = Gameplay_User_Model_UserModel__get_ExperienceProgress(iVar4,iVar4);
		    if (iVar1 == 0) {
		      return 1.0;
		    }
		    uVar3 = *(ulonglong *)(*(int *)(iVar4 + 8) + 0x58);
		    iVar4 = Gameplay_User_Model_UserModel__get_ExperienceProgress(iVar4,iVar4);
		    fVar2 = UnityEngine_Camera__set_orthographicSize
		                      ((float)uVar3,(float)*(ulonglong *)(iVar4 + 0x10),0);
		  }
		  else {
		    fVar2 = 0.0;
		  }
		  return fVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x00005700 File Offset: 0x00003900
		[Token(Token = "0x17000458")]
		public float ExperienceProgress
		{
			[Token(Token = "0x600187A")]
			[Address(RVA = "0x6A1A", Offset = "0x6A1A", VA = "0x6A1A")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600187B")]
		[Address(RVA = "0x6A1B", Offset = "0x6A1B", VA = "0x6A1B")]
		public static SkillCollection GetUserSkills(SkillCollection skills)
		{
			return null;
		}

		// Token: 0x04000D10 RID: 3344
		[Token(Token = "0x4000D10")]
		[FieldOffset(Offset = "0x10")]
		public UserSkillsData SkillsData;

		// Token: 0x04000D11 RID: 3345
		[Token(Token = "0x4000D11")]
		[FieldOffset(Offset = "0x14")]
		public InventoryModel InventoryUserModel;

		// Token: 0x04000D12 RID: 3346
		[Token(Token = "0x4000D12")]
		[FieldOffset(Offset = "0x18")]
		public RepeatedField<CultDic> AvailableCults;

		// Token: 0x04000D13 RID: 3347
		[Token(Token = "0x4000D13")]
		[FieldOffset(Offset = "0x1C")]
		public SkillCollection UserSkills;

		// Token: 0x04000D14 RID: 3348
		[Token(Token = "0x4000D14")]
		[FieldOffset(Offset = "0x20")]
		public List<GenderDic> AvailableGenders;

		// Token: 0x04000D15 RID: 3349
		[Token(Token = "0x4000D15")]
		[FieldOffset(Offset = "0x24")]
		public Dictionary<Genders, Dictionary<uint, AprDicWrapper>> AvailableAprsByGender;

		// Token: 0x04000D17 RID: 3351
		[Token(Token = "0x4000D17")]
		[FieldOffset(Offset = "0x2C")]
		public readonly IDictProvider DictProvider;

		// Token: 0x02000414 RID: 1044
		[Token(Token = "0x2000414")]
		public class UserSkill : Skill
		{
			// Token: 0x0600187C RID: 6268 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600187C")]
			[Address(RVA = "0x6A1C", Offset = "0x6A1C", VA = "0x6A1C")]
			public UserSkill()
			{
			}

			// Token: 0x04000D1A RID: 3354
			[Token(Token = "0x4000D1A")]
			[FieldOffset(Offset = "0x18")]
			public UserSkillDic SkillDic;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_LoggedUser ---
		uint Gameplay_UserInfo_Model_UserInfoModel__get_LoggedUser(int param1,undefined4 param2)
		
		{
		  return (uint)(*(int *)(param1 + 8) != *(int *)(*(int *)(param1 + 0xc) + 8));
		}
		*/


		/* --- GHIDRA: set_Game ---
		undefined4 Gameplay_UserInfo_Model_UserInfoModel__set_Game(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a59903 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59903 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x28);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x8108cbbb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8108cbbb:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetGenderDic(uVar3,6,0);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: set_CurrentSelectedApr ---
		void Gameplay_UserInfo_Model_UserInfoModel__set_CurrentSelectedApr(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x20) = 0;
		  *(undefined4 *)(param1 + 0x28) = 0;
		  *(undefined8 *)(param1 + 0xc) = 0;
		  *(undefined8 *)(param1 + 0x14) = 0;
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_ExperienceProgress ---
		undefined4
		Gameplay_UserInfo_Model_UserInfoModel__get_ExperienceProgress(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59905 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData__get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_int__SkillData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_int__SkillData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_int__SkillData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_int__SkillData__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UserSkillsIndexes__Contains__);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_SkillCollection_TypeInfo);
		    DAT_ram_00a59905 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  param1_00 = unnamed_function_1417(Core_Data_Skills_SkillCollection_TypeInfo);
		  Core_Data_Skills_EffectSkillsMapping___cctor(param1_00,0);
		  uVar2 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (param1,Method_System_Collections_Generic_Dictionary_int__SkillData__get_Keys__)
		  ;
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_int__SkillData__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x213,&local_10,
		                         Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_int__SkillData__MoveNext__
		                        );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8108cebd;
		      }
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return param1_00;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar3 = local_8._4_4_;
		      uVar2 = import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x37,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8108cebd;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x38,uVar2,iVar3 + -1,
		                         Method_System_Collections_Generic_List_UserSkillsIndexes__Contains__);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8108cebd;
		      }
		    } while (iVar4 != 0);
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x32,param1,iVar3,
		                       Method_System_Collections_Generic_Dictionary_int__SkillData__get_Item__);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x259,param1_00,iVar3,uVar2,
		               Method_System_Collections_Generic_Dictionary_int__SkillData__Add__);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8108cebd:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return param1_00;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x39,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
