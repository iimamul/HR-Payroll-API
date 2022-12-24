﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HR_Payroll_API.Entities;
using AutoMapper;
using HR_Payroll_API.DTO;

namespace HR_Payroll_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveBalancesController : ControllerBase
    {
        private readonly HrPayrollContext _context;
        private readonly IMapper _mappper;

        public LeaveBalancesController(HrPayrollContext context, IMapper mapper)
        {
            _context = context;
            _mappper = mapper;
        }

        // GET: api/LeaveBalances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeaveBalanceDTO>>> GetLeaveBalances()
        {
          if (_context.LeaveBalances == null)
          {
              return NotFound();
          }
          var leaveBalance= await _context.LeaveBalances.ToListAsync();
            //return await _context.LeaveBalances.ToListAsync();
            return _mappper.Map<List<LeaveBalance>, List<LeaveBalanceDTO>>(leaveBalance);
        }

        // GET: api/LeaveBalances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveBalance>> GetLeaveBalance(int id)
        {
          if (_context.LeaveBalances == null)
          {
              return NotFound();
          }
            var leaveBalance = await _context.LeaveBalances.FindAsync(id);

            if (leaveBalance == null)
            {
                return NotFound();
            }

            return leaveBalance;
        }

        // PUT: api/LeaveBalances/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLeaveBalance(int id, LeaveBalance leaveBalance)
        {
            if (id != leaveBalance.Id)
            {
                return BadRequest();
            }

            _context.Entry(leaveBalance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeaveBalanceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LeaveBalances
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LeaveBalance>> PostLeaveBalance(LeaveBalanceDTO leaveBalanceDto)
        {
          if (_context.LeaveBalances == null)
          {
              return Problem("Entity set 'HrPayrollContext.LeaveBalances'  is null.");
          }
            var leaveBalance = _mappper.Map<LeaveBalanceDTO, LeaveBalance>(leaveBalanceDto);
            _context.LeaveBalances.Add(leaveBalance);
            await _context.SaveChangesAsync();

            return Ok(leaveBalanceDto);
        }

        // DELETE: api/LeaveBalances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLeaveBalance(int id)
        {
            if (_context.LeaveBalances == null)
            {
                return NotFound();
            }
            var leaveBalance = await _context.LeaveBalances.FindAsync(id);
            if (leaveBalance == null)
            {
                return NotFound();
            }

            _context.LeaveBalances.Remove(leaveBalance);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LeaveBalanceExists(int id)
        {
            return (_context.LeaveBalances?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
