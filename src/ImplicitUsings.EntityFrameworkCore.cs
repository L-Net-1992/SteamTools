// C# 10 定义全局 using

#pragma warning disable IDE0079 // 请删除不必要的忽略
#pragma warning disable IDE0005
#pragma warning disable SA1209 // Using alias directives should be placed after other using directives
#pragma warning disable SA1211 // Using alias directives should be ordered alphabetically by alias name

global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Infrastructure;
global using Microsoft.EntityFrameworkCore.Metadata;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
#if !__NOT_IMPORT_Z_EF_PLUS__
global using Z.EntityFramework.Plus;
#endif

global using AutoMapper;
global using AutoMapper.QueryableExtensions;
global using AutoMapper.EquivalencyExpression;