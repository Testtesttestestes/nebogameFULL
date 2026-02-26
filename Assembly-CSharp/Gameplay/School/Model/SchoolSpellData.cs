using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Balance;
using Core.Data.Effect;
using Core.Data.Spells;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using Utils;

namespace Gameplay.School.Model
{
	// Token: 0x02000648 RID: 1608
	[Token(Token = "0x2000648")]
	public class SchoolSpellData : SpellData
	{
		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060026F4 RID: 9972 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026F5 RID: 9973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000752")]
		public Dictionary<uint, EffectData> EffectsNextLevel
		{
			[Token(Token = "0x60026F4")]
			[Address(RVA = "0x7829", Offset = "0x7829", VA = "0x7829")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026F5")]
			[Address(RVA = "0x782A", Offset = "0x782A", VA = "0x782A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026F7 RID: 9975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000753")]
		public SpellLevelDic SpellNextLevelDic
		{
			[Token(Token = "0x60026F6")]
			[Address(RVA = "0x782B", Offset = "0x782B", VA = "0x782B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026F7")]
			[Address(RVA = "0x782C", Offset = "0x782C", VA = "0x782C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x17000754")]
		public override uint Level
		{
			[Token(Token = "0x60026F8")]
			[Address(RVA = "0x782D", Offset = "0x782D", VA = "0x782D", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000755")]
		public string IconAssetId
		{
			[Token(Token = "0x60026F9")]
			[Address(RVA = "0x782E", Offset = "0x782E", VA = "0x782E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x00007770 File Offset: 0x00005970
		// (set) Token: 0x060026FB RID: 9979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000756")]
		public uint BackTime
		{
			[Token(Token = "0x60026FA")]
			[Address(RVA = "0x222B", Offset = "0x222B", VA = "0x222B")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60026FB")]
			[Address(RVA = "0x782F", Offset = "0x782F", VA = "0x782F")]
			set
			{
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060026FC RID: 9980 RVA: 0x00007788 File Offset: 0x00005988
		// (set) Token: 0x060026FD RID: 9981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000757")]
		public uint ActionBacktime
		{
			[Token(Token = "0x60026FC")]
			[Address(RVA = "0x7830", Offset = "0x7830", VA = "0x7830")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60026FD")]
			[Address(RVA = "0x7831", Offset = "0x7831", VA = "0x7831")]
			set
			{
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060026FE RID: 9982 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x17000758")]
		public bool IsLearning
		{
			[Token(Token = "0x60026FE")]
			[Address(RVA = "0x7832", Offset = "0x7832", VA = "0x7832")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x000077B8 File Offset: 0x000059B8
		[Token(Token = "0x17000759")]
		public bool IsMaxLevel
		{
			[Token(Token = "0x60026FF")]
			[Address(RVA = "0x7833", Offset = "0x7833", VA = "0x7833")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700075A")]
		public ResourceSet PriceOfUseNext
		{
			[Token(Token = "0x6002700")]
			[Address(RVA = "0x7834", Offset = "0x7834", VA = "0x7834")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x000077D0 File Offset: 0x000059D0
		[Token(Token = "0x1700075B")]
		public long ManaPriceOfUseNext
		{
			[Token(Token = "0x6002701")]
			[Address(RVA = "0x7835", Offset = "0x7835", VA = "0x7835")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06002702 RID: 9986 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700075C")]
		public virtual ResourceSet LearnPrice
		{
			[Token(Token = "0x6002702")]
			[Address(RVA = "0x7836", Offset = "0x7836", VA = "0x7836", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x1700075D")]
		public virtual double PriceCoef
		{
			[Token(Token = "0x6002703")]
			[Address(RVA = "0x7837", Offset = "0x7837", VA = "0x7837", Slot = "11")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002704")]
		[Address(RVA = "0x7838", Offset = "0x7838", VA = "0x7838")]
		public SchoolSpellData(ShortSpellInfo shortSpellInfo, Dictionaries dict)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_School_Model_SchoolSpellData___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a059 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_SchoolModel__SchoolEvents__Dispose__);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellStartedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellFinishedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellCanceledEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController_OnLearnSpellAcceleratedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController_OnLearnSpellCanceledEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController_OnLearnSpellFinishedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController_OnLearnSpellStartedEvent__);
		    DAT_ram_00a5a059 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellStartedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_School_Controller_SchoolController_OnLearnSpellStartedEvent__,0);
		  ServicesNamespace_SchoolService__add_LearnSpellStarted(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_School_Controller_SchoolController_OnLearnSpellAcceleratedEvent__,0);
		  ServicesNamespace_SchoolService__add_LearnSpellAccelerated(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellFinishedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_School_Controller_SchoolController_OnLearnSpellFinishedEvent__,0);
		  ServicesNamespace_SchoolService__add_LearnSpellFinished(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellCanceledEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_School_Controller_SchoolController_OnLearnSpellCanceledEvent__,0);
		  ServicesNamespace_SchoolService__add_LearnSpellCanceled(uVar2,uVar1,0);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  if (*(int *)(param1 + 0x1c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x1c),0);
		    *(undefined4 *)(param1 + 0x1c) = 0;
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_SchoolModel__SchoolEvents__Dispose__);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_School_Model_SchoolSpellData___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a059 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_SchoolModel__SchoolEvents__Dispose__);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellStartedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellFinishedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellCanceledEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController_OnLearnSpellAcceleratedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController_OnLearnSpellCanceledEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController_OnLearnSpellFinishedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_School_Controller_SchoolController_OnLearnSpellStartedEvent__);
		    DAT_ram_00a5a059 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellStartedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_School_Controller_SchoolController_OnLearnSpellStartedEvent__,0);
		  ServicesNamespace_SchoolService__add_LearnSpellStarted(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_School_Controller_SchoolController_OnLearnSpellAcceleratedEvent__,0);
		  ServicesNamespace_SchoolService__add_LearnSpellAccelerated(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellFinishedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_School_Controller_SchoolController_OnLearnSpellFinishedEvent__,0);
		  ServicesNamespace_SchoolService__add_LearnSpellFinished(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellCanceledEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_School_Controller_SchoolController_OnLearnSpellCanceledEvent__,0);
		  ServicesNamespace_SchoolService__add_LearnSpellCanceled(uVar2,uVar1,0);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  if (*(int *)(param1 + 0x1c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x1c),0);
		    *(undefined4 *)(param1 + 0x1c) = 0;
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_SchoolModel__SchoolEvents__Dispose__);
		  return;
		}
		*/

		}

		// Token: 0x06002705 RID: 9989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002705")]
		[Address(RVA = "0x7839", Offset = "0x7839", VA = "0x7839")]
		public SchoolSpellData(ShortSpellInfo shortSpellInfo, IBalanceSource balance, Dictionaries dict)
		{
		}

		// Token: 0x0400155B RID: 5467
		[Token(Token = "0x400155B")]
		[FieldOffset(Offset = "0x34")]
		public ShortSpellInfo ShortSpellInfo;

		// Token: 0x0400155C RID: 5468
		[Token(Token = "0x400155C")]
		[FieldOffset(Offset = "0x38")]
		private BackTime _backTime;

		// Token: 0x0400155D RID: 5469
		[Token(Token = "0x400155D")]
		[FieldOffset(Offset = "0x3C")]
		private BackTime _actionBackTime;

		// Token: 0x0400155E RID: 5470
		[Token(Token = "0x400155E")]
		[FieldOffset(Offset = "0x40")]
		private ResourceSet _priceOfUseNext;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Level ---
		undefined4 Gameplay_School_Model_SchoolSpellData__get_Level(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_SpellDicExt__GetAssetId(*(undefined4 *)(param1 + 0xc),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_IconAssetId ---
		void Gameplay_School_Model_SchoolSpellData__get_IconAssetId
		               (int param1,uint param2,undefined4 param3)
		
		{
		  float param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a053 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5a053 = '\x01';
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331((ulonglong)param2,0);
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		  *(undefined4 *)(param1 + 0x38) = param1_00;
		  return;
		}
		*/


		/* --- GHIDRA: get_BackTime ---
		int * Gameplay_School_Model_SchoolSpellData__get_BackTime(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_BackTime ---
		int Gameplay_School_Model_SchoolSpellData__set_BackTime(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  int iVar2;
		  int iVar3;
		  
		  fVar1 = func_ii_7103(*(undefined4 *)(param1 + 0x3c),0);
		  fVar1 = CEIL(fVar1);
		  if (fVar1 < 4.2949673e+09 && 0.0 <= fVar1) {
		    iVar2 = (int)fVar1;
		  }
		  else {
		    iVar2 = 0;
		  }
		  if (2.1474836e+09 <= ABS(fVar1)) {
		    iVar3 = -0x80000000;
		    if (0.0 <= fVar1) {
		      iVar3 = iVar2;
		    }
		    return iVar3;
		  }
		  iVar3 = (int)fVar1;
		  if (0.0 <= fVar1) {
		    iVar3 = iVar2;
		  }
		  return iVar3;
		}
		*/


		/* --- GHIDRA: get_ActionBacktime ---
		void Gameplay_School_Model_SchoolSpellData__get_ActionBacktime
		               (int param1,uint param2,undefined4 param3)
		
		{
		  float param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a054 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5a054 = '\x01';
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331((ulonglong)param2,0);
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		  *(undefined4 *)(param1 + 0x3c) = param1_00;
		  return;
		}
		*/


		/* --- GHIDRA: set_ActionBacktime ---
		uint Gameplay_School_Model_SchoolSpellData__set_ActionBacktime(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  int iVar2;
		  int iVar3;
		  
		  fVar1 = func_ii_7103(*(undefined4 *)(param1 + 0x38),0);
		  fVar1 = CEIL(fVar1);
		  if (fVar1 < 4.2949673e+09 && 0.0 <= fVar1) {
		    iVar2 = (int)fVar1;
		  }
		  else {
		    iVar2 = 0;
		  }
		  if (ABS(fVar1) < 2.1474836e+09) {
		    iVar3 = (int)fVar1;
		  }
		  else {
		    iVar3 = -0x80000000;
		  }
		  if (0.0 <= fVar1) {
		    iVar3 = iVar2;
		  }
		  return (uint)(iVar3 != 0);
		}
		*/


		/* --- GHIDRA: get_IsLearning ---
		uint Gameplay_School_Model_SchoolSpellData__get_IsLearning(int param1,undefined4 param2)
		
		{
		  return (uint)(*(int *)(param1 + 0x30) == 0);
		}
		*/


		/* --- GHIDRA: get_IsMaxLevel ---
		int Gameplay_School_Model_SchoolSpellData__get_IsMaxLevel(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x40);
		  if (iVar1 == 0) {
		    iVar1 = Utils_MoneyUtils__ExtractSpellCostMoney(*(undefined4 *)(param1 + 0x1c),0);
		  }
		  *(int *)(param1 + 0x40) = iVar1;
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_PriceOfUseNext ---
		undefined8 Gameplay_School_Model_SchoolSpellData__get_PriceOfUseNext(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a055 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		    DAT_ram_00a5a055 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (*(undefined4 *)(param1 + 0x1c),0,
		                     Method_System_Collections_Generic_Dictionary_int__Skill__get_Item__);
		  return *(undefined8 *)(iVar1 + 0x10);
		}
		*/


		/* --- GHIDRA: get_ManaPriceOfUseNext ---
		undefined4
		Gameplay_School_Model_SchoolSpellData__get_ManaPriceOfUseNext(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  float fVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *param1_00;
		  double param2_00;
		  uint uVar7;
		  
		  if (DAT_ram_00a5a056 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a5a056 = '\x01';
		  }
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0xf4));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(param1,uVar1);
		  uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  if (iVar2 != 0) {
		    fVar3 = func_ii_7103(param1[0xe],0);
		    fVar3 = CEIL(fVar3);
		    if (fVar3 < 4.2949673e+09 && 0.0 <= fVar3) {
		      iVar2 = (int)fVar3;
		    }
		    else {
		      iVar2 = 0;
		    }
		    if (ABS(fVar3) < 2.1474836e+09) {
		      iVar6 = (int)fVar3;
		    }
		    else {
		      iVar6 = -0x80000000;
		    }
		    if (0.0 <= fVar3) {
		      iVar6 = iVar2;
		    }
		    if (iVar6 != 0) {
		      param2_00 = *(double *)(param1[0xd] + 0x20);
		      goto code_r0x811ba164;
		    }
		  }
		  uVar1 = CONCAT44(uVar5,*(undefined4 *)(*param1 + 0x11c));
		  param2_00 = (double)(**(code **)((ulonglong)*(uint *)(*param1 + 0x118) * 4))(param1,uVar1);
		  uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		code_r0x811ba164:
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8 + 4) * 8 + iVar2 + 0x160);
		        goto code_r0x811ba1ff;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar7);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x811ba1ff:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,CONCAT44(uVar5,puVar4[1]));
		  iVar2 = Core_Gameplay_Managers_Requirements_RequirementsManager__Deinit
		                    (uVar5,*(undefined4 *)(param1[0xc] + 0x2c),0);
		  if (iVar2 == 0) {
		    uVar5 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		    return uVar5;
		  }
		  uVar5 = Protocol_Common_ResourceSet___ctor(*(undefined4 *)(iVar2 + 0x10),0);
		  uVar5 = Core_Extensions_Dict_ResourceSetExt__Round(uVar5,param2_00,0);
		  uVar5 = Core_Extensions_Dict_ResourceSetExt__SetValue(uVar5,0);
		  return uVar5;
		}
		*/


		/* --- GHIDRA: get_LearnPrice ---
		double Gameplay_School_Model_SchoolSpellData__get_LearnPrice(undefined4 param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  double dVar3;
		  int *param1_00;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a5a057 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28182);
		    DAT_ram_00a5a057 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar5 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x811ba30e;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811ba30e:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  dVar3 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar2,StringLiteral_28182,0);
		  return dVar3;
		}
		*/


		/* --- GHIDRA: get_PriceCoef ---
		void Gameplay_School_Model_SchoolSpellData__get_PriceCoef
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  float fVar3;
		  int param3_00;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int param2_01;
		  int iVar4;
		  
		  if (DAT_ram_00a5a058 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__EffectData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__EffectData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__EffectData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Effect_EffectData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_long___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    DAT_ram_00a5a058 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__EffectData__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,Method_System_Collections_Generic_Dictionary_uint__EffectData___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = uVar2;
		  Core_Data_Spells_SpellData___ctor
		            (param1,*(undefined4 *)(param2 + 0xc),*(undefined4 *)(param2 + 0x10),param3,0);
		  *(int *)(param1 + 0x34) = param2;
		  uVar1 = *(uint *)(param2 + 0x14);
		  if (DAT_ram_00a5a053 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5a053 = '\x01';
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar3 = func_ii_7331((ulonglong)uVar1,0);
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,fVar3,0);
		  *(undefined4 *)(param1 + 0x38) = uVar2;
		  uVar1 = *(uint *)(param2 + 0x18);
		  if (DAT_ram_00a5a054 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5a054 = '\x01';
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar3 = func_ii_7331((ulonglong)uVar1,0);
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,fVar3,0);
		  *(undefined4 *)(param1 + 0x3c) = uVar2;
		  iVar4 = *(int *)(param1 + 0x10);
		  if (iVar4 == 0) {
		    iVar4 = Core_Extensions_Dict_DictExt__GetSpell
		                      (param3,*(undefined4 *)(param2 + 0xc),*(int *)(param2 + 0x10) + 1,0);
		  }
		  else {
		    iVar4 = Core_Extensions_Dict_DictExt__GetSpell
		                      (param3,*(undefined4 *)(iVar4 + 0x14),*(undefined4 *)(iVar4 + 0x18),0);
		  }
		  *(int *)(param1 + 0x30) = iVar4;
		  if (iVar4 != 0) {
		    param2_01 = 0;
		    uVar2 = System_Linq_Enumerable__ToList_int_
		                      (*(undefined4 *)(iVar4 + 0x1c),Method_System_Linq_Enumerable_ToList_long___);
		    uVar2 = Core_Data_Skills_Skills__AddMods(uVar2,0);
		    *(undefined4 *)(param1 + 0x1c) = uVar2;
		    iVar4 = *(int *)(*(int *)(*(int *)(param1 + 0xc) + 0x24) + 0xc);
		    if (0 < iVar4) {
		      do {
		        uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(*(int *)(param1 + 0xc) + 0x24),param2_01,
		                           Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		        param3_00 = Core_Extensions_Dict_DictExt__GetEffect
		                              (param3,uVar2,*(undefined4 *)(*(int *)(param1 + 0x30) + 0x10),0);
		        if (param3_00 != 0) {
		          param2_00 = Core_Extensions_Dict_DictExt__GetSpellLevelDic(param3,uVar2,0);
		          param1_00 = unnamed_function_1417(Core_Data_Effect_EffectData_TypeInfo);
		          UnityEngine_Purchasing_Default_Factory__Create(param1_00,param2_00,param3_00,0);
		          System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		                    (*(undefined4 *)(param1 + 0x2c),uVar2,param1_00,
		                     Method_System_Collections_Generic_Dictionary_uint__EffectData__Add__);
		        }
		        param2_01 = param2_01 + 1;
		      } while (param2_01 != iVar4);
		    }
		  }
		  return;
		}
		*/

}
