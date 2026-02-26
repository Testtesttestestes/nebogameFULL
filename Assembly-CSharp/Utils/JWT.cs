using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	public class JWT
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005B")]
		public JWT.JWTContent Content
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x56E8", Offset = "0x56E8", VA = "0x56E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x1700005C")]
		public TimeSpan Duration
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x56E9", Offset = "0x56E9", VA = "0x56E9")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x56EA", Offset = "0x56EA", VA = "0x56EA")]
		public long GetBackTime()
		{
		/* --- GHIDRA: GetBackTime ---
		uint Utils_JWT__GetBackTime(undefined4 param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  
		  lVar1 = Utils_JWT__get_Duration(param1,param1);
		  return (uint)(lVar1 < 1);
		}
		*/

			return 0L;
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x1700005D")]
		public bool IsExpired
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x56EB", Offset = "0x56EB", VA = "0x56EB")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x56EC", Offset = "0x56EC", VA = "0x56EC")]
		private JWT(string payload)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Utils_JWT___ctor(undefined4 param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined1 auStack_c [4];
		  undefined4 local_8;
		  
		  if (DAT_ram_00a627df == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_JWT_TypeInfo);
		    DAT_ram_00a627df = '\x01';
		  }
		  *param2 = 0;
		  Localization_Culture_WebGL_CultureProvider__LocaleToSystemLang(auStack_c,param1,0);
		  iVar1 = unnamed_function_1417(Utils_JWT_TypeInfo);
		  if (DAT_ram_00a627de == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_JsonUtility_FromJson_JWT_JWTContent___);
		    DAT_ram_00a627de = '\x01';
		  }
		  *(undefined4 *)(iVar1 + 8) = local_8;
		  uVar2 = func_ii_5995(local_8,Method_UnityEngine_JsonUtility_FromJson_JWT_JWTContent___);
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  *param2 = iVar1;
		  return 1;
		}
		*/

		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x56ED", Offset = "0x56ED", VA = "0x56ED")]
		public static bool TryParse(string token, out JWT jwtObj)
		{
		/* --- GHIDRA: TryParse ---
		undefined4 Utils_JWT__TryParse(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined8 uVar4;
		  longlong lVar5;
		  longlong lVar6;
		  double dVar7;
		  undefined8 local_80;
		  undefined8 local_78;
		  undefined8 local_70;
		  undefined8 local_68;
		  undefined8 local_60;
		  undefined8 local_58;
		  undefined8 local_50;
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a627e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_47);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9001);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3526);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2364);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2365);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6244);
		    Mono_Security_ASN1__get_Item(&StringLiteral_524);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7038);
		    DAT_ram_00a627e0 = '\x01';
		  }
		  local_18 = 0;
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_00,0);
		  func_ii_2010(param1_00,StringLiteral_47,0);
		  func_ii_2010(param1_00,StringLiteral_2365,0);
		  func_ii_2010(param1_00,StringLiteral_47,0);
		  uVar4 = *(undefined8 *)(*(int *)(param1 + 0xc) + 8);
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  System_DateTimeOffset__Equals(&local_28,uVar4,0);
		  local_8 = local_20;
		  local_10 = local_28;
		  System_DateTimeOffset__ParseExact(&local_38,&local_10,0);
		  local_40 = local_30;
		  local_48 = local_38;
		  uVar2 = func_ii_1081(System_DateTimeOffset_TypeInfo,&local_48);
		  uVar2 = func_ii_4419(StringLiteral_9001,uVar2,0);
		  func_ii_2010(param1_00,uVar2,0);
		  func_ii_2010(param1_00,StringLiteral_47,0);
		  uVar4 = *(undefined8 *)(*(int *)(param1 + 0xc) + 0x10);
		  System_DateTimeOffset__Equals(&local_58,uVar4,0);
		  local_8 = local_50;
		  local_10 = local_58;
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  System_DateTimeOffset__ParseExact(&local_68,&local_10,0);
		  local_70 = local_60;
		  local_78 = local_68;
		  uVar3 = func_ii_1081(System_DateTimeOffset_TypeInfo,&local_78);
		  uVar3 = func_ii_4419(StringLiteral_7038,uVar3,0);
		  func_ii_2010(param1_00,uVar3,0);
		  func_ii_2010(param1_00,StringLiteral_47,0);
		  if (DAT_ram_00a627dc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    DAT_ram_00a627dc = '\x01';
		  }
		  lVar5 = *(longlong *)(*(int *)(param1 + 0xc) + 8);
		  lVar6 = *(longlong *)(*(int *)(param1 + 0xc) + 0x10);
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_TimeSpan_TypeInfo);
		  }
		  dVar7 = (double)(lVar6 - lVar5);
		  local_80 = System_Threading_CancellationTokenSource___ctor(dVar7,0);
		  uVar1 = (undefined4)((ulonglong)dVar7 >> 0x20);
		  uVar3 = func_ii_1081(System_TimeSpan_TypeInfo,&local_80);
		  uVar3 = func_ii_4419(StringLiteral_6244,uVar3,0);
		  func_ii_2010(param1_00,uVar3,0);
		  func_ii_2010(param1_00,StringLiteral_47,0);
		  lVar5 = Utils_JWT__get_Duration(param1,&local_80);
		  uVar3 = StringLiteral_3526;
		  param2_00 = StringLiteral_524;
		  if (0 < lVar5) {
		    lVar5 = Utils_JWT__get_Duration(param1,&local_80);
		    if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_TimeSpan_TypeInfo);
		    }
		    dVar7 = (double)lVar5;
		    local_18 = System_Threading_CancellationTokenSource___ctor(dVar7,0);
		    uVar1 = (undefined4)((ulonglong)dVar7 >> 0x20);
		    param2_00 = System_TimeSpan__TryParseExact(&local_18,0);
		  }
		  uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar3,param2_00,0);
		  func_ii_2010(param1_00,uVar3,0);
		  func_ii_2010(param1_00,StringLiteral_47,0);
		  func_ii_2010(param1_00,StringLiteral_2364,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                    (CONCAT44(uVar1,param1_00),CONCAT44(uVar2,*(undefined4 *)(*param1_00 + 0xdc)));
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x56EE", Offset = "0x56EE", VA = "0x56EE", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Payload;

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		[Serializable]
		public class JWTContent
		{
			// Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x56EF", Offset = "0x56EF", VA = "0x56EF")]
			public JWTContent()
			{
			}

			// Token: 0x040000FC RID: 252
			[Token(Token = "0x40000FC")]
			[FieldOffset(Offset = "0x8")]
			public long iat;

			// Token: 0x040000FD RID: 253
			[Token(Token = "0x40000FD")]
			[FieldOffset(Offset = "0x10")]
			public long exp;

			// Token: 0x040000FE RID: 254
			[Token(Token = "0x40000FE")]
			[FieldOffset(Offset = "0x18")]
			public string sub;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Content ---
		undefined8 Utils_JWT__get_Content(int param1,undefined4 param2)
		
		{
		  undefined8 uVar1;
		  longlong lVar2;
		  longlong lVar3;
		  
		  if (DAT_ram_00a627dc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    DAT_ram_00a627dc = '\x01';
		  }
		  lVar2 = *(longlong *)(*(int *)(param1 + 0xc) + 8);
		  lVar3 = *(longlong *)(*(int *)(param1 + 0xc) + 0x10);
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_TimeSpan_TypeInfo);
		  }
		  uVar1 = System_Threading_CancellationTokenSource___ctor((double)(lVar3 - lVar2),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Duration ---
		longlong Utils_JWT__get_Duration(int param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a627dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a627dd = '\x01';
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  if (DAT_ram_00a62826 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a62826 = '\x01';
		  }
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  func_ii_13875(&local_20,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  lVar1 = System_DateTimeOffset__get_Now(&local_10,0);
		  return *(longlong *)(*(int *)(param1 + 0xc) + 0x10) - lVar1;
		}
		*/


		/* --- GHIDRA: get_IsExpired ---
		void Utils_JWT__get_IsExpired(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a627de == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_JsonUtility_FromJson_JWT_JWTContent___);
		    DAT_ram_00a627de = '\x01';
		  }
		  *(undefined4 *)(param1 + 8) = param2;
		  uVar1 = func_ii_5995(param2,Method_UnityEngine_JsonUtility_FromJson_JWT_JWTContent___);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  return;
		}
		*/

}
